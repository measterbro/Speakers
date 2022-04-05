using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Security2.Data;
using Security2.Models;

namespace Security.Controllers
{
    public class SpeakersController : Controller
    {
        private readonly Security2Context _context;

        public SpeakersController(Security2Context context)
        {
            _context = context;
        }

        // GET: Speakers
        public async Task<IActionResult> Index()
        {
            var speakerList = await _context.Speaker.FromSqlRaw($"SalesOps.GetSpeakers").ToArrayAsync();
            return View(speakerList);
        }

        // GET: Speakers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var authorId = new SqlParameter("@ID", id);
            var speaker = (await _context.Speaker.FromSqlRaw($"SalesOps.GetSpeakerByID @ID", authorId).ToListAsync()).FirstOrDefault();
            return View(speaker);
        }

        // GET: Speakers/Create
        public IActionResult Create()
        {
            populateViewBags();

            return View();
        }

        // POST: Speakers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SpeakerFirstName,SpeakerLastName,SpeakerStatus,EffectiveDate,TerminationDate,TrainingStatus,TypeOfAgreement,SpeakerAddress,AddressType2,SpeakerEmail,SpeakerInstitution,SpeakerFellowshipEntity,NationalSpeaker,Npi,PractitionerType,SpeakerPracticeSpecialty,TerritoryID,CategoryCd,CategoryOther,ContractDuration,Address1,Address2,City,State,Zip")] SpeakerStatusModel speaker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speaker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(speaker);
        }

        //GET: Speakers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorId = new SqlParameter("@ID", id);
            var speaker = (await _context.SpeakerStatusModel.FromSqlRaw($"SalesOps.GetSpeakersTest @ID", authorId).ToListAsync()).FirstOrDefault();

            if (speaker == null)
            {
                return NotFound();
            }

            populateViewBags();
            return View(speaker);
        }

        // POST: Speakers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SpeakerFirstName,SpeakerLastName,SpeakerStatus,EffectiveDate,TerminationDate,TrainingStatus,TypeOfAgreement,SpeakerAddress,AddressType,SpeakerEmail,SpeakerInstitution,SpeakerFellowshipEntity,NationalSpeaker,Npi,PractitionerType,SpeakerPracticeSpecialty,TerritoryID,CategoryCD,CategoryOther,Duration,Address1,Address2,City,State,Zip")] SpeakerStatusModel speaker)
        {
            if (id != speaker.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speaker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpeakerExists(speaker.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Edit));
            }
            return View(speaker);
        }
        
        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorId = new SqlParameter("@ID", id);
            var speaker = (await _context.Speaker.FromSqlRaw($"SalesOps.GetSpeakerByID @ID", authorId).ToListAsync()).FirstOrDefault();
            return View(speaker);

            //var speaker = await _context.SpeakerStatusModel
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (speaker == null)
            //{
            //    return NotFound();
            //}
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var speaker = await _context.SpeakerStatusModel.FindAsync(id);
            _context.SpeakerStatusModel.Remove(speaker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpeakerExists(int id)
        {
            return _context.Speaker.Any(e => e.Id == id);
        }
        private void populateViewBags()
        {
            List<SpeakerStatusLookupModel> statusTypeList = new();
            statusTypeList = (from SpeakerStatus in _context.SpeakerStatusLookupModel select SpeakerStatus).ToList();
            statusTypeList.Insert(0, new SpeakerStatusLookupModel { Id = 0, SpeakerStatus = "Select" });
            ViewBag.statusTypeList = statusTypeList;

            List<SpeakerTypeOfAgreementLookupModel> TypeOfAgreementList = new();
            TypeOfAgreementList = (from TypeOfAgreement in _context.SpeakerTypeOfAgreementLookupModel select TypeOfAgreement).ToList();
            TypeOfAgreementList.Insert(0, new SpeakerTypeOfAgreementLookupModel { Id = 0, TypeOfAgreement = "Select" });
            ViewBag.TypeOfAgreementList = TypeOfAgreementList;

            List<SpeakerAddressTypeLookupModel> AddressTypeList = new();
            AddressTypeList = (from AddressType in _context.SpeakerAddressTypeLookupModel select AddressType).ToList();
            AddressTypeList.Insert(0, new SpeakerAddressTypeLookupModel { Id = 0, AddressType = "Select" });
            ViewBag.AddressTypeList = AddressTypeList;

            List<SpeakerPractitionerTypeLookupModel> PractitionerTypeList = new();
            PractitionerTypeList = (from PractitionerType in _context.SpeakerPractitionerTypeLookupModel select PractitionerType).ToList();
            PractitionerTypeList.Insert(0, new SpeakerPractitionerTypeLookupModel { Id = 0, PractitionerType = "Select" });
            ViewBag.PractitionerTypeList = PractitionerTypeList;

            List<SpeakerPracticeSpecialtyLookupModel> PracticeSpecialtyList = new();
            PracticeSpecialtyList = (from PracticeSpecialty in _context.SpeakerPracticeSpecialtyLookupModel select PracticeSpecialty).ToList();
            PracticeSpecialtyList.Insert(0, new SpeakerPracticeSpecialtyLookupModel { Id = 0, PracticeSpecialty = "Select" });
            ViewBag.PracticeSpecialtyList = PracticeSpecialtyList;

            List<TerritoryLookupModel> TerritoryList = new();
            TerritoryList = (from TerritoryManager in _context.TerritoryLookupModel select TerritoryManager).ToList();
            TerritoryList.Insert(0, new TerritoryLookupModel { TerritoryId = 0, TerritoryManager = "Select" });
            ViewBag.TerritoryList = TerritoryList;

            List<SpeakerCategoriesLookupModel> CategoryList = new();
            CategoryList = (from Category in _context.SpeakerCategoriesLookupModel select Category).ToList();
            CategoryList.Insert(0, new SpeakerCategoriesLookupModel { Id = 0, Category = "Select" });
            ViewBag.CategoryList = CategoryList;

            List<SpeakerContractDurationLookupModel> DurationList = new();
            DurationList = (from Duration in _context.SpeakerContractDurationLookupModel select Duration).ToList();
            DurationList.Insert(0, new SpeakerContractDurationLookupModel { Id = 0, Duration = "Select" });
            ViewBag.DurationList = DurationList;
        }
    }
}
