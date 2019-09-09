using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketingSys.Domain.Contracts;

namespace TicketingSys.Web.Controllers
{
    public class GeneralController : Controller
    {
        private IIssueSeverityService issueSeverityService;
        private IIssueTypeService issueTypeService;
        private IResolutionStatusService iIResolutionStatusService;

        public GeneralController(IIssueSeverityService issueSeverityService, IIssueTypeService issueTypeService, IResolutionStatusService resolutionStatusService)
        {
            this.issueSeverityService = issueSeverityService;
            this.issueTypeService = issueTypeService;
            this.iIResolutionStatusService = resolutionStatusService;
        }

        /// <summary>
        /// Gets the issue severities.
        /// </summary>
        /// <returns></returns>
        public async Task<JsonResult> GetIssueSeveritiesAsync()
        {
            return Json(await this.issueSeverityService.GetIssueSeveritiesAsync().ConfigureAwait(false));
        }

        /// <summary>
        /// Gets the issue types asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<JsonResult> GetIssueTypesAsync()
        {
            return Json(await this.issueTypeService.GetIssueTypesAsync().ConfigureAwait(false));
        }

        /// <summary>
        /// Gets the resolution statuses asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<JsonResult> GetResolutionStatusesAsync()
        {
            return Json(await this.iIResolutionStatusService.GetResolutionStatusAsync().ConfigureAwait(false));
        }
    }
}