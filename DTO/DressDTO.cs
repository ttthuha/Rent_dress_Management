using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DressDTO
    {
        private int _DressID;
        private string _DressName;
        private float _DressPrice;
        private string _DressDecription;

        public int DressID
        {
            get
            {
                return _DressID;
            }
            set
            {
                _DressID = value;
            }
        }

        public string DressName
        {
            get
            {
                return _DressName;
            }
            set
            {
                _DressName = value;
            }
        }

        public float DressPrice
        {
            get
            {
                return _DressPrice;
            }
            set
            {
                _DressPrice = value;
            }
        }

        public string DressDecription
        {
            get
            {
                return _DressDecription;
            }
            set
            {
                _DressDecription = value;
            }
        }

        public DressDTO() { }

        public DressDTO(int DrID, string DrName)
        {
            this.DressID = DrID;
            this.DressName = DrName;
        }

        public DressDTO(string DrName, string DrDesc, float DrPrice, int DrID)
        {
            this.DressID = DrID;
            this.DressName = DrName;
            this.DressDecription = DrDesc;
            this.DressPrice = DrPrice;
        }

        public DressDTO(string DrName, string DrDesc, float DrPrice)
        {
            this.DressName = DrName;
            this.DressDecription = DrDesc;
            this.DressPrice = DrPrice;
        }
    }
}
