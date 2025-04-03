using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    class Programmer
    {
        //объявление делегата для множественных событий
        public delegate void MultipleProgrammerEventHandler(string message);

        //события, которые вызываются при изменении имени программиста и при добавлении нового свойства
        public event MultipleProgrammerEventHandler MultipleRename;
        public event MultipleProgrammerEventHandler MultipleNewProperty;
        //дополнительные события и методы для вызова их
        public event MultipleProgrammerEventHandler AnotherEvent;
        public event MultipleProgrammerEventHandler YetAnotherEvent;

        public delegate void ProgrammerEventHandler(string message);
        public event ProgrammerEventHandler Rename;//событие, которое вызывается при изменении имени программиста
        public event ProgrammerEventHandler NewProperty;//событие, которое вызывается при добавлении нового 
        private string name;
        public Programmer(string Name)
        {
            //приватное поле
            name = Name;
        }
        //методы для вызова 
        public void CommandAddOperation() => NewProperty.Invoke("Обработчик события NewProperty вызван");
        public void CommandRenameOperation() => Rename.Invoke("Обработчик события Rename вызван");
        //дополнительные методы для вызова множественных событий
        public void CommandMultipleRenameOperation() => MultipleRename?.Invoke("Множественный обработчик события Rename вызван");
        public void CommandMultipleNewPropertyOperation() => MultipleNewProperty?.Invoke("Множественный обработчик события NewProperty вызван");
        public void CommandAnotherEventOperation() => AnotherEvent?.Invoke("Дополнительное событие AnotherEvent вызвано");
        public void CommandYetAnotherEventOperation() => YetAnotherEvent?.Invoke("Дополнительное событие YetAnotherEvent вызвано");
    }
}
