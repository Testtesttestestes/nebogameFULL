using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	public class WorldIndexButtonsView : MonoBehaviour
	{
		// Token: 0x14000112 RID: 274
		// (add) Token: 0x060016AC RID: 5804 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060016AD RID: 5805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000112")]
		public event Action HomeButtonClickedEvent
		{
			[Token(Token = "0x60016AC")]
			[Address(RVA = "0x686D", Offset = "0x686D", VA = "0x686D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60016AD")]
			[Address(RVA = "0x686E", Offset = "0x686E", VA = "0x686E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000113 RID: 275
		// (add) Token: 0x060016AE RID: 5806 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060016AF RID: 5807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000113")]
		public event Action ZigguratButtonClickedEvent
		{
			[Token(Token = "0x60016AE")]
			[Address(RVA = "0x686F", Offset = "0x686F", VA = "0x686F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60016AF")]
			[Address(RVA = "0x6870", Offset = "0x6870", VA = "0x6870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x6871", Offset = "0x6871", VA = "0x6871")]
		private void Awake()
		{
		/* --- GHIDRA: <Awake>b__8_1 ---
		void Gameplay_UserInterface_View_WorldIndexButtonsView___Awake_b__8_1(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58271 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		              );
		    DAT_ram_00a58271 = '\x01';
		  }
		  param1_00 = Core_Animations_GameSpineUiAnimation__Play(*(undefined4 *)(param1 + 0x10),0.0,0.3,0);
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (param1_00,param2_00,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		            );
		  func_ii_7357(*(undefined4 *)(param1 + 0x14),0,0);
		  return;
		}
		*/

		/* --- GHIDRA: Awake ---
		void Gameplay_UserInterface_View_WorldIndexButtonsView__Awake(int param1,undefined4 param2)
		
		{
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4),0);
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4),0);
		  return;
		}
		*/

		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x6872", Offset = "0x6872", VA = "0x6872")]
		private void OnDestroy()
		{
		}

		// Token: 0x170003D6 RID: 982
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D6")]
		public bool HomeButtonEnabled
		{
			[Token(Token = "0x60016B2")]
			[Address(RVA = "0x6873", Offset = "0x6873", VA = "0x6873")]
			set
			{
			}
		}

		// Token: 0x170003D7 RID: 983
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D7")]
		public bool ZigguratButtonEnabled
		{
			[Token(Token = "0x60016B3")]
			[Address(RVA = "0x6874", Offset = "0x6874", VA = "0x6874")]
			set
			{
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x6875", Offset = "0x6875", VA = "0x6875")]
		public WorldIndexButtonsView()
		{
		}

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _homeButton;

		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _zigguratButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_HomeButtonClickedEvent ---
		void Gameplay_UserInterface_View_WorldIndexButtonsView__add_HomeButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5826d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5826d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_HomeButtonClickedEvent ---
		void Gameplay_UserInterface_View_WorldIndexButtonsView__remove_HomeButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5826e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5826e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ZigguratButtonClickedEvent ---
		void Gameplay_UserInterface_View_WorldIndexButtonsView__add_ZigguratButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5826f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5826f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ZigguratButtonClickedEvent ---
		void Gameplay_UserInterface_View_WorldIndexButtonsView__remove_ZigguratButtonClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58270 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_View_WorldIndexButtonsView__Awake_b__8_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_View_WorldIndexButtonsView__Awake_b__8_1__);
		    DAT_ram_00a58270 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_UserInterface_View_WorldIndexButtonsView__Awake_b__8_0__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_UserInterface_View_WorldIndexButtonsView__Awake_b__8_1__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
