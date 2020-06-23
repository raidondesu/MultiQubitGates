namespace MultiQubitGates {
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    

    @EntryPoint()
    operation CompoundGate() : Unit {
        using(qs = Qubit[3]){
            S(qs[0]);
            Y(qs[2]);
        }
    }

    operation BellState() : Unit {
        using(qs = Qubit[2]){
            H(qs[0]);
            CNOT(qs[0], qs[1]);
        }
    }
}

