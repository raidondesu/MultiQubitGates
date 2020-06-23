//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MultiQubitGates\",\"Name\":\"CompoundGate\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":6,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/Reaper/Desktop/Quantum/MultiQubitGates/MultiQubitGates/Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MultiQubitGates\",\"Name\":\"CompoundGate\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Reaper/Desktop/Quantum/MultiQubitGates/MultiQubitGates/Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
#line hidden
namespace MultiQubitGates
{
    [SourceLocation("C:/Users/Reaper/Desktop/Quantum/MultiQubitGates/MultiQubitGates/Program.qs", OperationFunctor.Body, 8, -1)]
    public partial class CompoundGate : Operation<QVoid, QVoid>, ICallable
    {
        public CompoundGate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CompoundGate";
        String ICallable.FullName => "MultiQubitGates.CompoundGate";
        public static EntryPointInfo<QVoid, QVoid> Info => new EntryPointInfo<QVoid, QVoid>(typeof(CompoundGate));
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicS
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicY
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumDiagnosticsDumpMachine
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 9 "C:/Users/Reaper/Desktop/Quantum/MultiQubitGates/MultiQubitGates/Program.qs"
                var qs = Allocate.Apply(3L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 10 "C:/Users/Reaper/Desktop/Quantum/MultiQubitGates/MultiQubitGates/Program.qs"
                    MicrosoftQuantumIntrinsicS.Apply(qs[0L]);
#line 11 "C:/Users/Reaper/Desktop/Quantum/MultiQubitGates/MultiQubitGates/Program.qs"
                    MicrosoftQuantumIntrinsicY.Apply(qs[2L]);
#line 12 "C:/Users/Reaper/Desktop/Quantum/MultiQubitGates/MultiQubitGates/Program.qs"
                    MicrosoftQuantumDiagnosticsDumpMachine.Apply(QVoid.Instance);
#line 14 "C:/Users/Reaper/Desktop/Quantum/MultiQubitGates/MultiQubitGates/Program.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(qs[3L]);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release.Apply(qs);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Y));
            this.MicrosoftQuantumDiagnosticsDumpMachine = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Diagnostics.DumpMachine<>));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<CompoundGate, QVoid, QVoid>(QVoid.Instance);
        }
    }
}