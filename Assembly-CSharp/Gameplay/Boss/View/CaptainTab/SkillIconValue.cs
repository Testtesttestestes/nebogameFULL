using System;
using Core.Data.Skills;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B86 RID: 2950
	[Token(Token = "0x2000B86")]
	[RequireComponent(typeof(SimpleIconValue))]
	public class SkillIconValue : MonoBehaviour
	{
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x060047B5 RID: 18357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E57")]
		protected SimpleIconValue SimpleIconValue
		{
			[Token(Token = "0x60047B5")]
			[Address(RVA = "0x9641", Offset = "0x9641", VA = "0x9641")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060047B6 RID: 18358 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047B7 RID: 18359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E58")]
		public Skill Skill
		{
			[Token(Token = "0x60047B6")]
			[Address(RVA = "0x9642", Offset = "0x9642", VA = "0x9642")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047B7")]
			[Address(RVA = "0x1BA1", Offset = "0x1BA1", VA = "0x1BA1")]
			set
			{
			}
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B8")]
		[Address(RVA = "0x9643", Offset = "0x9643", VA = "0x9643")]
		public SkillIconValue()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Boss_View_CaptainTab_SkillIconValue___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a57a71 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Sorting_UserDataComparers_ByCult_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Sorting_UserDataComparers_ByLevel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Sorting_UserDataComparers_ByNick_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IGameDataComparer_UserData___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IGameDataComparer_UserData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_IGameDataComparer_UserData___TypeInfo);
		    DAT_ram_00a57a71 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_IGameDataComparer_UserData___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IGameDataComparer_UserData____ctor__);
		  uVar2 = unnamed_function_1417(Core_Sorting_UserDataComparers_ByLevel_TypeInfo);
		  Core_Sorting_UserDataComparers_ByLevel__get_Title(uVar2,0);
		  iVar1 = Method_System_Collections_Generic_List_IGameDataComparer_UserData___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417(Core_Sorting_UserDataComparers_ByCult_TypeInfo);
		  Core_Sorting_UserDataComparers_ByCult__get_Title(uVar2,0);
		  iVar1 = Method_System_Collections_Generic_List_IGameDataComparer_UserData___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417(Core_Sorting_UserDataComparers_ByNick_TypeInfo);
		  Core_Sorting_UserDataComparers_ByNick__get_Title(uVar2,0);
		  iVar1 = Method_System_Collections_Generic_List_IGameDataComparer_UserData___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    return param1_00;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return param1_00;
		}
		*/

		}

		// Token: 0x0400276A RID: 10090
		[Token(Token = "0x400276A")]
		[FieldOffset(Offset = "0x10")]
		private SimpleIconValue _simpleIconValue;

		// Token: 0x0400276B RID: 10091
		[Token(Token = "0x400276B")]
		[FieldOffset(Offset = "0x14")]
		private Skill _skill;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Skill ---
		int * Gameplay_Boss_View_CaptainTab_SkillIconValue__set_Skill(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
