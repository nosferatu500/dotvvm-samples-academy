using System.Collections.Generic;
using System.Threading.Tasks;
using DotvvmAcademy.DTO;
using DotvvmAcademy.Services;
using DotVVM.Framework.Hosting;

namespace DotvvmAcademy.ViewModels
{
    public class DefaultViewModel : SiteViewModel
    {
        public List<LessonDTO> Lessons { get; private set; }

        public override Task Init()
        {
            var storage = new LessonProgressStorage(Context.GetAspNetCoreContext());
            Lessons = new List<LessonDTO>
            {
                new LessonDTO
                {
                    Number = 1,
                    LastStep = storage.GetLessonLastStep(1),
                    Title = "Понимание базовых принципов DotVVM и MVVM паттерна.",
                    ImageUrl = "/img/basics.png"
                },
                new LessonDTO
                {
                    Number = 2,
                    LastStep = storage.GetLessonLastStep(2),
                    Title = "Узнаете, как использовать <code>Repeater</code> и как работать с коллекциями.",
                    ImageUrl = "/img/elementary.png"
                },
                new LessonDTO
                {
                    Number = 3,
                    LastStep = storage.GetLessonLastStep(3),
                    Title =
                        "Попробуйте поработать с расширенными элементами управления, такими как <code>ComboBox</code> и <code>RadioButton</code>.",
                    ImageUrl = "/img/intermediate.png"
                },
                new LessonDTO
                {
                    Number = 4,
                    LastStep = storage.GetLessonLastStep(4),
                    Title = "Узнаете, как работают проверки и <code>DataContext</code>.",
                    ImageUrl = "/img/advanced.png"
                },
                //new LessonDTO
                //{
                //    Number = 5,
                //    LastStep = storage.GetLessonLastStep(5),
                //    Title = "Understand <code>GridView</code> and loading data from <code>IQueryable</code>.",
                //    ImageUrl = "/img/professional.png"
                //}
            };

            return base.Init();
        }
    }
}