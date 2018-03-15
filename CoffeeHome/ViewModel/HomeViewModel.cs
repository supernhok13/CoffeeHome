﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeHome.TemplateView;
using System.Collections.ObjectModel;
using CoffeeHome.Model;

namespace CoffeeHome.ViewModel
{
    class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<ItemField> Items { get; }

        public AdminTemplate template = new AdminTemplate();
        public HomeViewModel()
        {
            this.Items = new ObservableCollection<ItemField>(){
                  new ItemField("Thức uống & Đồ ăn",this.template,"Images/drink-food.png"),
                  new ItemField("Loại thức uống",this.template,"Images/drink-type.png")
            };        }
    }
}