using System;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;

namespace Gameplay.World.Controller
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	public class WorldAxisLevelViewMediator : AbstractWorldViewMediator
	{
		// Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x6665", Offset = "0x6665", VA = "0x6665")]
		public WorldAxisLevelViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Controller_WorldAxisLevelViewMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a58175 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IIsle__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IIsle___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IIsle__TypeInfo);
		    DAT_ram_00a58175 = '\x01';
		  }
		  Gameplay_World_Controller_AbstractWorldViewMediator___ctor(param1,param2,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_IIsle__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_IIsle___ctor__);
		    iVar2 = Method_System_Collections_Generic_List_IIsle__Add__;
		    uVar1 = *(undefined4 *)(param1[2] + 0x2c);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_World_View_WorldView__GetIsleEngineByLevel
		              (uVar1,0xffffffff,*(undefined4 *)(param1[2] + 0x2c),0,0,0,param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000365 RID: 869
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		public override WorldView View
		{
			[Token(Token = "0x60014A4")]
			[Address(RVA = "0x6666", Offset = "0x6666", VA = "0x6666", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x6667", Offset = "0x6667", VA = "0x6667", Slot = "21")]
		public override void Clear()
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x6668", Offset = "0x6668", VA = "0x6668", Slot = "22")]
		protected override void StartMovement()
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x6669", Offset = "0x6669", VA = "0x6669", Slot = "23")]
		protected override void CompleteMovement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_World_Controller_WorldAxisLevelViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_World_View_WorldView__MoveToIsle(param1_00,0xffffffff,0);
		  return;
		}
		*/

}
