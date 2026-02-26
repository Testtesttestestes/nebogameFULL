using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Tutorial.Guide.View.Components
{
	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	public class Overlap : MonoBehaviourWithStates<OverlapType>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000131 RID: 305
		// (add) Token: 0x06001AFF RID: 6911 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001B00 RID: 6912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000131")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6001AFF")]
			[Address(RVA = "0x6C89", Offset = "0x6C89", VA = "0x6C89")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001B00")]
			[Address(RVA = "0x6C8A", Offset = "0x6C8A", VA = "0x6C8A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x6C8B", Offset = "0x6C8B", VA = "0x6C8B")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Tutorial_Guide_View_Components_Overlap__Awake
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58473 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_OverlapType__HandleCurrentStateChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_OverlapType__get_CurrentState__)
		    ;
		    DAT_ram_00a58473 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_Int32Enum____ctor
		            (param1,param2,param3,
		             Method_UI_MonoBehaviourWithStates_OverlapType__HandleCurrentStateChanged__);
		  if (*(int *)(param1 + 0x18) == 1) {
		    iVar1 = **(int **)(param1 + 0x1c);
		    local_18 = *(undefined8 *)(param1 + 0x28);
		    local_20 = *(undefined8 *)(param1 + 0x20);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		              (*(int **)(param1 + 0x1c),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  }
		  else if (*(int *)(param1 + 0x18) == 2) {
		    iVar1 = **(int **)(param1 + 0x1c);
		    local_8 = *(undefined8 *)(param1 + 0x38);
		    local_10 = *(undefined8 *)(param1 + 0x30);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		              (*(int **)(param1 + 0x1c),&local_10,*(undefined4 *)(iVar1 + 0x17c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x6C8C", Offset = "0x6C8C", VA = "0x6C8C", Slot = "4")]
		protected override void HandleCurrentStateChanged(OverlapType fromState, OverlapType toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		void Gameplay_Tutorial_Guide_View_Components_Overlap__HandleCurrentStateChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  float4 local_4;
		  
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x170) * 4))
		            (&local_10,*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0x174));
		  if (param2 != (float)local_4) {
		    iVar1 = **(int **)(param1 + 0x1c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x170) * 4))
		              (&local_10,*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0x174));
		    local_18 = local_8;
		    local_20 = local_10;
		    iVar1 = **(int **)(param1 + 0x1c);
		    local_28 = CONCAT44(param2,local_8);
		    local_30 = local_10;
		    local_4 = (float4)param2;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		              (*(int **)(param1 + 0x1c),&local_30,*(undefined4 *)(iVar1 + 0x17c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x6C8D", Offset = "0x6C8D", VA = "0x6C8D")]
		public void SetShadeAlpha(float alpha)
		{
		/* --- GHIDRA: SetShadeAlpha ---
		void Gameplay_Tutorial_Guide_View_Components_Overlap__SetShadeAlpha
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58474 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_OverlapType__get_CurrentState__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_OverlapType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8753);
		    DAT_ram_00a58474 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) == 2) {
		    local_4 = 2;
		    uVar1 = func_ii_1081(Gameplay_Tutorial_Guide_Model_OverlapType_TypeInfo,&local_4);
		    uVar1 = func_ii_4419(StringLiteral_8753,uVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		    iVar2 = *(int *)(param1 + 0x40);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x6C8E", Offset = "0x6C8E", VA = "0x6C8E", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Tutorial_Guide_View_Components_Overlap__OnPointerClick(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58475 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_OverlapType___ctor__);
		    DAT_ram_00a58475 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x30) = 0;
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x38) = 0x3f80000000000000;
		  *(undefined8 *)(param1 + 0x28) = 0x3f80000000000000;
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_OverlapType___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x6C8F", Offset = "0x6C8F", VA = "0x6C8F")]
		public Overlap()
		{
		}

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _image;

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _balackShadeColor;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _transparentColor;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Tutorial_Guide_View_Components_Overlap__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58471 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58471 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x40,param1_01,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Tutorial_Guide_View_Components_Overlap__remove_ClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58472 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_OverlapType__set_CurrentState__)
		    ;
		    DAT_ram_00a58472 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,Method_UI_MonoBehaviourWithStates_OverlapType__set_CurrentState__);
		  return;
		}
		*/

}
