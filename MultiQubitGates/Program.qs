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

    operation QubitSwap() : Unit {
        using(qs = Qubit[2]){
            SWAP(qs[0], qs[1]);
            Reset(qs[0]);
            Reset(qs[1]);
        }
    }

    operation ControlledRotation () : Unit {
        using(qs = Qubit[2]){
            Controlled Rx([qs[0]], (1.0, qs[1])); 
        }
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

