using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007C9 RID: 1993
	[Token(Token = "0x20007C9")]
	public class ActionAccount_1 : AbstractActionOnEvent
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x17000929")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002EEC")]
			[Address(RVA = "0x7F59", Offset = "0x7F59", VA = "0x7F59", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EED")]
		[Address(RVA = "0x7F5A", Offset = "0x7F5A", VA = "0x7F5A", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EEE")]
		[Address(RVA = "0x7F5B", Offset = "0x7F5B", VA = "0x7F5B")]
		public ActionAccount_1()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a574fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo);
		    DAT_ram_00a574fd = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo);
		  **(undefined4 **)(Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1__get_SortOrder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int *param1_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar5;
		  double dVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a574fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_AccountTag_8_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SingleOrDefault_AbstractTag___);
		    Mono_Security_ASN1__get_Item(&System_Func_AbstractTag__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c__Execute_b__3_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo);
		    DAT_ram_00a574fc = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x2c);
		  if (*(int *)(Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[1];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo + 0x74) == 0
		       ) {
		      func_ii_306000(Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_AbstractTag__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,param2_00,
		               Method_Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c__Execute_b__3_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1___c_TypeInfo + 0x5c)
		            + 4) = iVar4;
		  }
		  param1_00 = (int *)UI_SimpleIconValue__set_Value
		                               (uVar2,iVar4,
		                                Method_System_Linq_Enumerable_SingleOrDefault_AbstractTag___);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_AccountTag_8_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_AccountTag_8_TypeInfo + 0xb8) * 4 +
		                -4) != Gameplay_GameEvents_Model_Tags_AccountTag_8_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Gameplay_GameEvents_Model_Tags_AccountTag_8_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0x104));
		    uVar7 = 0;
		    param1_01 = *(int **)(iVar4 + 0xc);
		    iVar4 = *param1_01;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x1f8);
		          goto code_r0x80d9a80b;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80d9a80b:
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		    iVar5 = param1_00[5];
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xec));
		    dVar6 = *(double *)(iVar5 + iVar4 * 8 + 8);
		    if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		      iVar4 = (int)dVar6;
		    }
		    else {
		      iVar4 = 0;
		    }
		    if (ABS(dVar6) < 2147483648.0) {
		      iVar5 = (int)dVar6;
		    }
		    else {
		      iVar5 = -0x80000000;
		    }
		    if (0.0 <= dVar6) {
		      iVar5 = iVar4;
		    }
		    Core_Gameplay_Managers_AccountsManager__ShowAccountWindow(uVar2,iVar5,0);
		  }
		  return;
		}
		*/

}
