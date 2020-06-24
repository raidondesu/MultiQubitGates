namespace MultiQubitGates {
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    

    @EntryPoint()
    operation CompoundGate() : Unit {
        using(qs = Qubit[3]){
            S(qs[0]);
            Y(qs[2]);

            Reset(qs[0]);
            Reset(qs[2]);
        }
    }

    operation BellState() : Unit {
        using(qs = Qubit[2]){
            H(qs[0]);
            CNOT(qs[0], qs[1]);
            Reset(qs[0]);
            Reset(qs[1]);
        }
    }

    operation QubitSwap(qs : Qubit[], index1 : Int, index2 : Int) : Unit is Adj {
        SWAP(qs[index1], qs[index2]);
    }

    operation ControlledRotation (qs: Qubit[], theta: Double) : Unit is Adj{
        let control = qs[0];
        let target = qs[1];
        Controlled Rx([control], (theta, target));
    }
}

