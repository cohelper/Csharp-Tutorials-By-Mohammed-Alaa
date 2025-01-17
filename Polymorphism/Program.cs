﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 fast revesion:
To call method in childrens by base class obj. = polymorphism
 parent:virtual
 childs:override

 parent= new child();
 parent.method();
 */

/*
 لو عندك حيوان 
الحيوان بيمشي 
القطة بتمشي بطريقة 
القرد بيمشي بطريقة تانية 
وهكذا 

الفكرة ان الحيوان لازم يكون عنده خاصية المشي . 
وكل حيوان هيكون ليه طريقة مخصصة ف المشي . 
وانا عايز انادي علي فنكشن المشي بنفس الكلمة 
walk 
دا المقصود من البولي مورفزم 
انك تنادي بكلمة واحدة والكومبيلر يفهم انت عايز مين يمشي .. 
بدل ما تعمل 
CatWalk
MonkeyWalk
هتعمل 
walk 


هتعرف كلاس اسمه حيوان 
القرد هيورث من الكلاس دا 
والقطة هتورث برضه من نفس الكلاس

المطلوب انك تعرف طريقة مشي كل حيوان فيهم . 

الهدف من الموضوع دا ؟ 
اني اقول للحيوان امشي ف يمشي بطريقته 
walk();
---------------------------------------------------
ايه الميزة ف الموضوع دا ؟ 
استعملت كلمة واحدة 
Walk();
بخلي البيس كلاس يشاور علي الابناء وبنادي علي 
walk 
ف البيس كلاس وهو بيشوفها موجودة ف اي ابن ... 
----------------------------------------------------
يعني انت بتقوله الحاجة دي ال من نوع حيوان خليها تمشي ..

 */
namespace Polymorphism
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal cat = new Cat();
            Animal monkey = new Monkey();
            animal.Walk();
            cat.Walk();
            monkey.Walk();
        }
    }
}
