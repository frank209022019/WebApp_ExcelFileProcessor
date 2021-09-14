using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp_ExcelFileProcessor.Data;
using WebApp_ExcelFileProcessor.Models;
using WebApp_ExcelFileProcessor.ViewModels;

namespace WebApp_ExcelFileProcessor.Controllers
{
    [Authorize]
    public class BaseClassController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public BaseClassController(ILogger<HomeController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        [Authorize]
        public IActionResult UploadBaseClass()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UploadBaseClass(List<IFormFile> files)
        {
            try
            {
                FileDetailsViewModel model = new FileDetailsViewModel()
                {
                    DateUploaded = DateTime.Now
                };

                //  get file details
                if (files.Count() > 0)
                {
                    var file = files.FirstOrDefault();
                    using (var stream = new MemoryStream())
                    {
                        await file.CopyToAsync(stream);
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        using (ExcelPackage package = new ExcelPackage(stream))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                            model.TotalColumns = worksheet.Dimension.End.Column.ToString();
                            model.TotalRows = worksheet.Dimension.End.Row.ToString();
                            model.FileName = file.FileName;
                        }
                    }
                }

                //  save file details to database temp

                var processResult = await ProcessBaseClassUploadFile(files.FirstOrDefault());
                if (!processResult.ResponseValid)
                    throw new Exception("An error while uploading your file!");

                return Ok(new { success = true, message = "All files uploaded successfully!", result = model });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = "An error while uploading your file!" });
            }
        }

        [Authorize]
        public IActionResult UploadBaseClassResult()
        {
            UploadBaseClassResultViewModel model = new UploadBaseClassResultViewModel();
            var tempResults = _context.StudentTemps.ToList();
            if (tempResults.Count() > 0)
            {
                //  add to different model lists
                var createTemp = tempResults.Where(i => i.RowType == 'C').ToList();
                if (createTemp.Count() > 0)
                    model.CreateList = createTemp;
                var updateTemp = tempResults.Where(i => i.RowType == 'U').ToList();
                if (updateTemp.Count() > 0)
                    model.UpdateList = updateTemp;
                var errorTemp = tempResults.Where(i => i.RowType == 'E').ToList();
                if (errorTemp.Count() > 0)
                    model.ErrorList = errorTemp;

                return View(model);
            }
            else
            {
                return RedirectToAction("UploadBaseClass", "BaseClass");
            }
        }

        [Authorize]
        public IActionResult ManageBaseClass()
        {
            return View();
        }

        #region Utilities

        private async Task<UploadBaseClassProcessViewModel> ProcessBaseClassUploadFile(IFormFile file)
        {
            try
            {
                //  Clear all temp records
                var currentTempList = _context.StudentTemps.ToList();
                if (currentTempList.Count() > 0)
                {
                    _context.StudentTemps.RemoveRange(currentTempList);
                    _context.SaveChanges();
                }

                //  Database Lists
                var studentColorList = _context.StudentColors.ToList();
                var studentGroupList = _context.StudentGroups.ToList();
                var studentClassList = _context.StudentClasses.ToList();
                var genderList = _context.Genders.ToList();

                //  Lists for result view
                UploadBaseClassProcessViewModel returnValue = new UploadBaseClassProcessViewModel()
                {
                    ResponseId = null,
                    ResponseValid = true,
                    ResponseDateTime = DateTime.Now,
                    ResponseMessage = "File processing successful.",
                    SuccessList = new List<StudentTemp>(),
                    ErrorList = new List<StudentTemp>()
                };

                //  Process document
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (ExcelPackage package = new ExcelPackage(stream))
                    {
                        //  Get the first worksheet in the workbook
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int colCount = worksheet.Dimension.End.Column;
                        int rowCount = worksheet.Dimension.End.Row;

                        //  Loop through rows
                        if (rowCount > 0)
                        {
                            for (int row = 6; row <= rowCount; row++)
                            {
                                //  StudentTemp
                                Boolean rowIsEmpty = true;
                                Boolean rowHasError = false;
                                StudentTemp tempModel = new StudentTemp()
                                {
                                    RowNumber = row,
                                    IsDeleted = false,
                                    DateCreated = DateTime.Now
                                };

                                try
                                {
                                    //  Check if current rows columns have null values
                                    for (int col = 2; col <= 9; col++)
                                    {
                                        if (worksheet.Cells[row, col].Value == null)
                                            rowHasError = true;
                                    }

                                    //  Get values from row/col
                                    //Col2        Gold            StudentColor
                                    //Col3        G1                 StudentGroup
                                    //Col4        7                   StudentNr
                                    //Col5       CIN500       QR Code
                                    //Col6        Surname
                                    //Col7        Name
                                    //Col8        Gender
                                    //Col9        8A              StudentClass

                                    //  StudentColor
                                    if (worksheet.Cells[row, 2].Value != null)
                                    {
                                        var valueStudentColor = worksheet.Cells[row, 2].Value;
                                        if (valueStudentColor != null)
                                            tempModel.StudentColorId = studentColorList.SingleOrDefault(i => i.ColorName.ToUpper() == valueStudentColor.ToString().ToUpper()).StudentColorId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentColor"));
                                    }

                                    //  Student Group
                                    if (worksheet.Cells[row, 3].Value != null)
                                    {
                                        var valueStudentGroup = worksheet.Cells[row, 3].Value;
                                        if (valueStudentGroup != null)
                                            tempModel.StudentGroupId = studentGroupList.SingleOrDefault(i => i.DisplayName.ToUpper() == valueStudentGroup.ToString().ToUpper()).StudentGroupId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentGroup"));
                                    }

                                    //  Student Nr
                                    if (worksheet.Cells[row, 4].Value != null)
                                    {
                                        var valueStudentNr = worksheet.Cells[row, 4].Value;
                                        if (valueStudentNr != null)
                                            tempModel.StudentNr = Convert.ToInt32(valueStudentNr);
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentNr"));
                                    }

                                    //  QR Code
                                    if (worksheet.Cells[row, 5].Value != null)
                                    {
                                        var valueQRCode = worksheet.Cells[row, 5].Value;
                                        if (valueQRCode != null)
                                            tempModel.QRCode = valueQRCode.ToString().ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "QR"));
                                    }

                                    //  Last Name
                                    if (worksheet.Cells[row, 6].Value != null)
                                    {
                                        var valueLastName = worksheet.Cells[row, 6].Value;
                                        if (valueLastName != null)
                                            tempModel.LastName = valueLastName.ToString().ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "LastName"));
                                    }

                                    //  First Name
                                    if (worksheet.Cells[row, 7].Value != null)
                                    {
                                        var valueFirstName = worksheet.Cells[row, 7].Value;
                                        if (valueFirstName != null)
                                            tempModel.FirstName = valueFirstName.ToString().ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "FirstName"));
                                    }

                                    //  Gender
                                    if (worksheet.Cells[row, 8].Value != null)
                                    {
                                        var valueGender = worksheet.Cells[row, 8].Value;
                                        if (valueGender != null)
                                            tempModel.GenderId = genderList.FirstOrDefault(i => i.GenderChar.ToString().ToUpper() == valueGender.ToString().ToUpper()).GenderId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "Gender"));
                                    }

                                    //  Student Class
                                    if (worksheet.Cells[row, 9].Value != null)
                                    {
                                        var valueStudentClass = worksheet.Cells[row, 9].Value;
                                        if (valueStudentClass != null)
                                            tempModel.StudentClassId = studentClassList.FirstOrDefault(i => i.DisplayName.ToUpper() == valueStudentClass.ToString().ToUpper()).StudentClassId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentClass"));
                                    }

                                    //  Determine if row is create, update or error
                                    if (!rowHasError)
                                    {
                                        //  check if similar records already exists in the database
                                        var alreadyExists = CheckIfStudentExisits(tempModel);
                                        if (alreadyExists)
                                            tempModel.RowType = 'U';
                                        else
                                            tempModel.RowType = 'C';
                                        returnValue.SuccessList.Add(tempModel);
                                    }
                                    else
                                    {
                                        //  add row to a error list
                                        tempModel.RowType = 'E';
                                        returnValue.ErrorList.Add(tempModel);
                                    }
                                }
                                catch
                                {
                                    tempModel.RowType = 'E';
                                    returnValue.ErrorList.Add(tempModel);
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("No rows found in the document.");
                        }
                    }
                }

                //  Add lists to database
                if (returnValue.ErrorList.Count() > 0)
                {
                    _context.StudentTemps.AddRange(returnValue.ErrorList);
                    _context.SaveChanges();
                }
                if (returnValue.SuccessList.Count() > 0)
                {
                    _context.StudentTemps.AddRange(returnValue.SuccessList);
                    _context.SaveChanges();
                }

                return returnValue;
            }
            catch (Exception ex)
            {
                return new UploadBaseClassProcessViewModel() { ResponseId = null, ResponseValid = false, ResponseDateTime = DateTime.Now, ResponseMessage = ex.Message, SuccessList = new List<StudentTemp>(), ErrorList = new List<StudentTemp>() };
            }
        }

        private Boolean CheckIfStudentExisits(StudentTemp tempModel)
        {
            try
            {
                return _context.Students.Any(i => i.QRCode.ToUpper() == tempModel.QRCode.ToUpper() && i.FirstName.ToUpper() == tempModel.FirstName.ToUpper() 
                                                                                    && i.LastName.ToUpper() == tempModel.LastName.ToUpper());
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<StudentTemp>> GetCreateStudentList()
        {
            try
            {
                var tempResults = _context.StudentTemps.ToList();
                var returnList = tempResults.Where(i => i.RowType == 'C').ToList();
                if (returnList.Count() > 0)
                    return returnList.ToList();
                else
                    return new List<StudentTemp>();
            }
            catch(Exception ex)
            {
                return new List<StudentTemp>();
            }
        }
        public async Task<List<StudentTemp>> GetUpdateStudentList()
        {
            try
            {
                var tempResults = _context.StudentTemps.ToList();
                var returnList = tempResults.Where(i => i.RowType == 'U').ToList();
                if (returnList.Count() > 0)
                    return returnList.ToList();
                else
                    return new List<StudentTemp>();
            }
            catch (Exception ex)
            {
                return new List<StudentTemp>();
            }
        }
        public async Task<List<StudentTemp>> GetRowErrorStudentList()
        {
            try
            {
                var tempResults = _context.StudentTemps.ToList();
                var returnList = tempResults.Where(i => i.RowType == 'E').ToList();
                if (returnList.Count() > 0)
                    return returnList.ToList();
                else
                    return new List<StudentTemp>();
            }
            catch (Exception ex)
            {
                return new List<StudentTemp>();
            }
        }

        #endregion Utilities
    }
}