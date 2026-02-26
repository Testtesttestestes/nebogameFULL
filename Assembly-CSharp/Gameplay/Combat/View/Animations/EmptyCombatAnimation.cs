using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000983 RID: 2435
	[Token(Token = "0x2000983")]
	public class EmptyCombatAnimation : ICombatAnimation, IDisposable
	{
		// Token: 0x06003A17 RID: 14871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A17")]
		[Address(RVA = "0x899B", Offset = "0x899B", VA = "0x899B", Slot = "7")]
		public void Append(string path, bool isLeft)
		{
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A18")]
		[Address(RVA = "0x899C", Offset = "0x899C", VA = "0x899C", Slot = "8")]
		public void Append(CombatAnimation.IContent content)
		{
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A19")]
		[Address(RVA = "0x899D", Offset = "0x899D", VA = "0x899D", Slot = "9")]
		public void CancelLoad()
		{
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1A")]
		[Address(RVA = "0x899E", Offset = "0x899E", VA = "0x899E", Slot = "12")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Combat_View_Animations_EmptyCombatAnimation__Dispose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57e1e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e1e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatAnimation_IContent__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x1400018C RID: 396
		// (add) Token: 0x06003A1B RID: 14875 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A1C RID: 14876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400018C")]
		public event Action<CombatAnimation.IContent> OnAnimExecuteEvent
		{
			[Token(Token = "0x6003A1B")]
			[Address(RVA = "0x899F", Offset = "0x899F", VA = "0x899F", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A1C")]
			[Address(RVA = "0x89A0", Offset = "0x89A0", VA = "0x89A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A1D")]
		[Address(RVA = "0x89A1", Offset = "0x89A1", VA = "0x89A1", Slot = "6")]
		public OpToken<CombatAnimation.IContent, CombatAnimation.IContent> Load(string path)
		{
			return null;
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1E")]
		[Address(RVA = "0x89A2", Offset = "0x89A2", VA = "0x89A2", Slot = "11")]
		public void Reset()
		{
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1F")]
		[Address(RVA = "0x89A3", Offset = "0x89A3", VA = "0x89A3", Slot = "10")]
		public void Stop()
		{
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A20")]
		[Address(RVA = "0x89A4", Offset = "0x89A4", VA = "0x89A4")]
		public EmptyCombatAnimation()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Animations_EmptyCombatAnimation___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e21 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_Animations_LoseFieldAnimation__LoseEffect_d__2_TypeInfo);
		    DAT_ram_00a57e21 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Combat_View_Animations_LoseFieldAnimation__LoseEffect_d__2_TypeInfo
		                        );
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnAnimExecuteEvent ---
		void Gameplay_Combat_View_Animations_EmptyCombatAnimation__add_OnAnimExecuteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57e1f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e1f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatAnimation_IContent__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnAnimExecuteEvent ---
		int * Gameplay_Combat_View_Animations_EmptyCombatAnimation__remove_OnAnimExecuteEvent
		                (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a57e20 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e20 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__TypeInfo
		                               );
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (param1_00,
		             Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ctor__);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x118) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x11c));
		  return param1_00;
		}
		*/

}
