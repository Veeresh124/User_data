using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operations
{
    public class Student
    {
        public string Name;
        public int Id;
        public int Age;
        public string Address;
        public string Gender;


        public Student()
        {
            this.Name = Name;
            this.Id = Id;
            this.Age = Age;
            this.Address = Address;
            this.Gender = Gender;
        }
        public string getName
        {
            set { value = Name; }
        }
        public int getId
        {
            set { value = Id; }
        }
        public int getAge
        {
            set { value = Age; }
        }
        public string getAddress
        {
            set { value = Address; }
        }
        public string getGender
        {
            set { value = Gender; }
        }
        List<Student> studentList = new List<Student>();
        public void Add()
        {
            Console.WriteLine("enter the name to add.");
            var name = Console.ReadLine();
            Console.WriteLine("enter the id to add.");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the age to add.");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the address to add.");
            var address = Console.ReadLine();
            Console.WriteLine("enter the gender to add.");
            var gender = Console.ReadLine();
            Student stuAdd = new Student();
            stuAdd.Name = name;
            stuAdd.Id = id;
            stuAdd.Age = age;
            stuAdd.Address = address;
            stuAdd.Gender = gender;
            studentList.Add(stuAdd);
        }
        public void Display()
        {
            Console.WriteLine("the student details are.");
            foreach (var stu in studentList)
            {
                Console.WriteLine(JsonConvert.SerializeObject(stu));
            }
            if(studentList.Count == 0)
            {
                Console.WriteLine("list  is empty.");
            }

            
        }
        public void Delete()
        {
            Console.WriteLine("enter the id to be delete.");
            string delete = Console.ReadLine();
            switch (delete)
            {
                case "id":
                    {
                        Console.WriteLine("list of id.");
                        foreach (var a in studentList)
                        {
                            Console.WriteLine(JsonConvert.SerializeObject(a));
                            Console.WriteLine("enter the id to be delete.");
                            int del = int.Parse(Console.ReadLine());
                            Console.WriteLine("after delete.");
                            studentList.RemoveAll(a => a.Id == del);

                        }
                        foreach (var b in studentList)
                        {
                            Console.WriteLine(JsonConvert.SerializeObject(b));
                        }
                    }
                    break;

            }
        }
        public void Update()
        {
            Console.WriteLine("eter field to update:a.name b.id c.age d.address c.gender.");
            string field = Console.ReadLine();
            switch (field)
            {
                case "a":
                    {
                        Console.WriteLine("enter name to update. ");
                        var name = Console.ReadLine();
                        Console.WriteLine("before updating the name.");
                        var res = studentList.Where(x => x.Name.Equals(name)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(res));
                        Console.WriteLine("enter name to be updated. ");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("After updating the name.");
                        res.ForEach(a => a.Name = name1);
                        Console.WriteLine(JsonConvert.SerializeObject(res));

                    }
                    break;
                case "b'":
                    {
                        Console.WriteLine("enter id to update. ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("before updating the id.");
                        var res = studentList.Where(x => x.Id.Equals(id)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(res));
                        Console.WriteLine("enter id to be updated. ");
                        int id1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("After updating the Id.");
                        res.ForEach(a => a.Id = id1);
                        Console.WriteLine(JsonConvert.SerializeObject(res));

                    }
                    break;
                case "c":
                    {
                        Console.WriteLine("enter Age to update. ");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("before updating the Age.");
                        var res = studentList.Where(x => x.Id.Equals(age)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(res));
                        Console.WriteLine("enter Age to be updated. ");
                        int age1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("After updating the Age.");
                        res.ForEach(a => a.Age = age1);
                        Console.WriteLine(JsonConvert.SerializeObject(res));
                    }
                    break;
                case "d":
                    {
                        Console.WriteLine("enter Address to update. ");
                        var address = Console.ReadLine();
                        Console.WriteLine("before updating the Address.");
                        var res = studentList.Where(x => x.Address.Equals(address)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(res));
                        Console.WriteLine("enter Address to be updated. ");
                        string address1 = Console.ReadLine();
                        Console.WriteLine("After updating the Address.");
                        res.ForEach(a => a.Address = address1);
                        Console.WriteLine(JsonConvert.SerializeObject(res));

                    }
                    break;
                case "e":
                    {
                        Console.WriteLine("enter gender to update. ");
                        var gender = Console.ReadLine();
                        Console.WriteLine("before updating the Gender.");
                        var res = studentList.Where(x => x.Gender.Equals(gender)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(res));
                        Console.WriteLine("enter Address to be updated. ");
                        string gender1 = Console.ReadLine();
                        Console.WriteLine("After updating the Address.");
                        res.ForEach(a => a.Gender = gender1);
                        Console.WriteLine(JsonConvert.SerializeObject(res));

                    }
                    break;
            }




        }
        public void Sort()
        {
            Console.WriteLine("which field1 want to sort:1.name 2.id 3.age 4.address 5.gender ");
            int field1 = int.Parse(Console.ReadLine());
            switch (field1)
            {
                case 1:
                    {
                        var order = studentList.OrderBy(s => s.Name);
                        Console.WriteLine("the Order is:");
                        foreach (var std in order)
                            Console.WriteLine(std.Name);

                    }
                    break;
                case 2:
                    {
                        var order = studentList.OrderBy(i => i.Id);
                        Console.WriteLine("the Order is:");
                        foreach (var std in order)
                            Console.WriteLine(std.Id);
                    }
                    break;
                case 3:
                    {
                        var order = studentList.OrderBy(a => a.Age);
                        Console.WriteLine("the Order is:");
                        foreach (var std in order)
                            Console.WriteLine(std.Age);
                    }
                    break;
                case 4:
                    {
                        var order = studentList.OrderBy(d => d.Address);
                        Console.WriteLine("the Order is:");
                        foreach (var std in order)
                            Console.WriteLine(std.Address);
                    }
                    break;
                case 5:
                    {
                        var order = studentList.OrderBy(g => g.Gender);
                        Console.WriteLine("the Order is:");
                        foreach (var std in order)
                            Console.WriteLine(std.Gender);
                    }
                    break;
            }
        }
        public void Search()
        {
            Console.WriteLine("enter the field want to search:a.Name b.Id c.Age d.Address e.Gender");
            string field = Console.ReadLine();
            switch (field)
            {
                case "a":
                    {
                        Console.WriteLine("enter a name:");
                        string name = Console.ReadLine();
                        var n = studentList.Where(k => k.Name.Equals(name)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(n));
                    }
                    break;
                case "b":
                    {
                        Console.WriteLine("enter an Id:");
                        int id = int.Parse(Console.ReadLine());
                        var e = studentList.Where(k => k.Id.Equals(Id)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(e));
                    }
                    break;
                case "c":
                    {
                        Console.WriteLine("enter a Age:");
                        int age = int.Parse(Console.ReadLine());
                        var n = studentList.Where(k => k.Age.Equals(age)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(n));
                    }
                    break;
                case "d":
                    {
                        Console.WriteLine("enter a Address:");
                        string address = Console.ReadLine();
                        var d = studentList.Where(z => z.Address.Equals(address)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(d));
                    }
                    break;
                case "e":
                    {
                        Console.WriteLine("enter a gender:");
                        string gender = Console.ReadLine();
                        var y = studentList.Where(k => k.Gender.Equals(gender)).ToList();
                        Console.WriteLine(JsonConvert.SerializeObject(y));
                    }
                    break;

            }
        }
    }
}



