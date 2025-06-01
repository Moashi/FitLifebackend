﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Entities;

namespace BackEnd.ResAndReq.Res.Routine
{
    public class ResGetRoutineExercises : ResBase
    {
        public List<RoutineDayExercise> Exercises { get; set; }

        public ResGetRoutineExercises()
        {
            Exercises = new List<RoutineDayExercise>();
        }
    }

}
