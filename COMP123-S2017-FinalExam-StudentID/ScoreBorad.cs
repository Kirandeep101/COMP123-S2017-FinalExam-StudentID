/*
 * Name:Kirandeeep Kaur
 * Date:17/August/2017
 * StudentID:300915966
 * Description: Created Score Board Class
 * Version:0.2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_FinalExam_StudentID
{
    //instance variables
    public class ScoreBorad
    {
        private string _finalScoreTextBox;
        private int _score;
        private string _scoreTextBox;
        private int _time;
        private string _timetexbox;

        //private properties 
        //constructors
        public string FinalScoreTextBox
        {
            get
            {
                return FinalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = FinalScoreTextBox;
            }
        }
        public string ScoreTextBox
        {
            get
            {
                return ScoreTextBox;
            }
            set
            {
                this._scoreTextBox = ScoreTextBox;
            }
        }
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                this._scoreTextBox = Score();

            }
        }

        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                this._timetexbox = _time();
            }
        }
        public string TimeTextBox
        {
            get
            {
                return TimeTextBox;
            }
            set
            {
                this._timeTextBox = TimeTextBox;
            }
        }
    }
}
