using DatSr.Entities.Questions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.ContextData.QuestCon
{
    public class QuestionDbInitializer:DropCreateDatabaseAlways<QuestionContext>
    {
        protected override void Seed(QuestionContext context)
        {
            context.Questions.Add(new QuestionModel { Type=1, Question="Введите ваше имя"});
            context.Questions.Add(new QuestionModel { Type=1, Question="Введите вашу фамилию"});
            context.Questions.Add(new QuestionModel { Type=1, Question="Введите вашу фамилию"});
            context.Questions.Add(new QuestionModel { Type = 3, Question = "Укажите ваш пол" });
            context.Questions.Add(new QuestionModel { Type = 3, Question= "Хотели бы Вы работать у нас в компании?" });
            context.Questions.Add(new QuestionModel { Type=3, Question= "Готовы ли вы работать в 3 смены?" });
            context.Questions.Add(new QuestionModel { Type=3, Question= "Какое ваше любимое животное?" });
            context.Questions.Add(new QuestionModel { Type=2, Question= "Что привлекает Вас в нашей компании?" });
            context.Questions.Add(new QuestionModel { Type=2, Question= "Что для Вас самое главное в жизни?" });
            context.SaveChanges();

            context.Variants.Add(new VariantsModel { Variant = "Мужчина", QuestID = 4 });
            context.Variants.Add(new VariantsModel { Variant = "Женщина", QuestID = 4 });
            context.Variants.Add(new VariantsModel { Variant = "Да", QuestID = 5 });
            context.Variants.Add(new VariantsModel { Variant = "Нет", QuestID = 5 });
            context.Variants.Add(new VariantsModel { Variant = "Да", QuestID = 6 });
            context.Variants.Add(new VariantsModel { Variant = "Нет", QuestID = 6 });
            context.Variants.Add(new VariantsModel { Variant = "Кошка", QuestID = 7 });
            context.Variants.Add(new VariantsModel { Variant = "Собака", QuestID = 7 });
            context.Variants.Add(new VariantsModel { Variant = "Хомячок", QuestID = 7 });
            context.Variants.Add(new VariantsModel { Variant= "Высокая заработная плата", QuestID=8 });
            context.Variants.Add(new VariantsModel { Variant = "Дружный коллектив", QuestID = 8 });
            context.Variants.Add(new VariantsModel { Variant = "Интересные проекты", QuestID = 8 });
            context.Variants.Add(new VariantsModel { Variant = "Семья.", QuestID = 9});
            context.Variants.Add(new VariantsModel { Variant = "Работа.", QuestID = 9 });
            context.Variants.Add(new VariantsModel { Variant = "Родители.", QuestID = 9 });
            context.Variants.Add(new VariantsModel { Variant = "Родина.", QuestID = 9 });
            context.Variants.Add(new VariantsModel { Variant = "Выпить пива с друзьями.", QuestID = 9 });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
