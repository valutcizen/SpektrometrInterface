using System;

namespace SpektrometrCore
{
    public class SpektrometrStatus
    {
        public byte IoStatus;
        public byte MainStatus;
        public bool Pozycjonowanie1;
        public bool Pozycjonowanie2;
        public bool JazdaLewo1;
        public bool JazdaPrawo1;
        public bool JazdaLewo2;
        public bool JazdaPrawo2;
        public bool Input1;
        public bool Input2;
        public bool Input3;
        public bool Input4;
        public Int32 AktualneImpulsy1;
        public Int32 AktualneImpulsy2;
    }
}
