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

    operation MultiControls (controls : Qubit[], target : Qubit, controlBits : Bool[]) : Unit is Adj {
        for(index in 0 .. Length(controls) - 1) {
            if(controlBits[index] == false) {
                X(controls[index]);
            }
        }

        Controlled X(controls,target);

        for (index in 0 .. Length(controls) - 1) {
            if(controlBits[index] == false) {
                X(controls[index]);
            }
        }
    }

    operation QuickControls (controls : Qubit[], target : Qubit, controlBits : Bool[]) : Unit is Adj {
        within {
            for(index in 0 .. Length(controls) - 1) {
                if (controlBits[index] == false) {
                    X(controls[index]);
                }
            }
        } apply {
            Controlled X(controls,target);
        }

    }

    operation ControlWithLibrary (controls : Qubit[], target: Qubit, controlBits : Bool[]) : Unit is Adj {
        (ControlledOnBitString(controlBits, X))(controls,target);
    }
}

