using System.Collections.Generic;
using System.Web.Mvc;
using MVCExcercise.Models;
using MVCExcercise.Utilities;

namespace MVCExcercise.Controllers
{
    public class HomeController : Controller
    {
        private const string xml= 
            @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <AllProjects>
                  <Proj>
                    <ProjectId>1234</ProjectId>
                    <ProjectNumber>Test Project 1</ProjectNumber>
                    <AllSubmissions>
                      <Sub Type=""Primary Submission"">
                        <SubmissionID>1</SubmissionID>
                        <SubmissionNumber>ABC_XYZ</SubmissionNumber>
                      </Sub>
                      <Sub Type=""Secondary Submission"">
                        <SubmissionID>1</SubmissionID>
                        <SubmissionNumber>ABC_XYZ_2</SubmissionNumber>
                      </Sub>
                    </AllSubmissions>
                  </Proj>
                  <Proj>
                    <ProjectId>5678</ProjectId>
                    <ProjectNumber>Test Project 2</ProjectNumber>
                    <AllSubmissions>
                      <Sub Type=""Primary Submission"">
                        <SubmissionID>1</SubmissionID>
                        <SubmissionNumber>BlahBlah</SubmissionNumber>
                      </Sub>
                      <Sub Type=""Secondary Submission"">
                        <SubmissionID>1</SubmissionID>
                        <SubmissionNumber>NadaNada</SubmissionNumber>
                      </Sub>
                    </AllSubmissions>
                  </Proj>
                    <Proj>
                    <ProjectId>9999</ProjectId>
                    <ProjectNumber>Test Project 3</ProjectNumber>
                  </Proj>
                </AllProjects>";
        public ActionResult Index()
        {
            return View(XMLParserUtility.Deserialize<List<Proj>>(xml, "AllProjects"));
        }
    }
}