namespace MultiCubitGates {
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;

    operation CompoundGate (qs : Qubit[]) : Unit is Adj {
        S(qs[0]);
        I(qs[1]);
        Y(qs[2]);
        }
    
    operation BellState (qs : Qubit[]) : Unit is Adj {
        H(qs[0]);
        CNOT(qs[0], qs[1]);
    }
}

