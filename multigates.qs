namespace MultiCubitGates {
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Instrinsic;
    open Microsoft.Quantum.Canon;
    
    operation CompoundGate (qs : Qubit[]) : Unit is Adj {
        S(q[0]);
        I(qs[1]);
        Y(qs[2]);
        DumpMachine();
        }
}

