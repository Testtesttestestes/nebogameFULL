using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactComparer.View.SkillSelector
{
	// Token: 0x02000CDC RID: 3292
	[Token(Token = "0x2000CDC")]
	public class SkillSelectorItemView : MonoBehaviour
	{
		// Token: 0x140001E7 RID: 487
		// (add) Token: 0x06005026 RID: 20518 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005027 RID: 20519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E7")]
		public event Action<SkillSelectorItemView> SelectEvent
		{
			[Token(Token = "0x6005026")]
			[Address(RVA = "0x9E38", Offset = "0x9E38", VA = "0x9E38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005027")]
			[Address(RVA = "0x9E39", Offset = "0x9E39", VA = "0x9E39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06005028 RID: 20520 RVA: 0x0000EB08 File Offset: 0x0000CD08
		// (set) Token: 0x06005029 RID: 20521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103A")]
		public int SkillId
		{
			[Token(Token = "0x6005028")]
			[Address(RVA = "0x9E3A", Offset = "0x9E3A", VA = "0x9E3A")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005029")]
			[Address(RVA = "0x1D97", Offset = "0x1D97", VA = "0x1D97")]
			set
			{
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x0600502A RID: 20522 RVA: 0x0000EB20 File Offset: 0x0000CD20
		// (set) Token: 0x0600502B RID: 20523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103B")]
		public bool Selected
		{
			[Token(Token = "0x600502A")]
			[Address(RVA = "0x9E3B", Offset = "0x9E3B", VA = "0x9E3B")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600502B")]
			[Address(RVA = "0x9E3C", Offset = "0x9E3C", VA = "0x9E3C")]
			set
			{
			}
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502C")]
		[Address(RVA = "0x9E3D", Offset = "0x9E3D", VA = "0x9E3D")]
		private void Awake()
		{
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502D")]
		[Address(RVA = "0x9E3E", Offset = "0x9E3E", VA = "0x9E3E")]
		private void OnValueChangedEvent(bool value)
		{
		/* --- GHIDRA: OnValueChangedEvent ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView__OnValueChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58a21 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView_OnValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a58a21 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView_OnValueChangedEvent__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x0600502E RID: 20526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502E")]
		[Address(RVA = "0x9E3F", Offset = "0x9E3F", VA = "0x9E3F")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502F")]
		[Address(RVA = "0x9E40", Offset = "0x9E40", VA = "0x9E40")]
		public SkillSelectorItemView()
		{
		}

		// Token: 0x04002BB6 RID: 11190
		[Token(Token = "0x4002BB6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x04002BB7 RID: 11191
		[Token(Token = "0x4002BB7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04002BB8 RID: 11192
		[Token(Token = "0x4002BB8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _skillIcon;

		// Token: 0x04002BBA RID: 11194
		[Token(Token = "0x4002BBA")]
		[FieldOffset(Offset = "0x20")]
		private int _skillId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectEvent ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView__add_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a1e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SkillSelectorItemView__TypeInfo);
		    DAT_ram_00a58a1e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_SkillSelectorItemView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SkillSelectorItemView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: get_SkillId ---
		uint Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView__get_SkillId
		               (int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 0x10) + 0xc4);
		}
		*/


		/* --- GHIDRA: get_Selected ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView__get_Selected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  func_ii_7603(*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView__set_Selected
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58a20 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView_OnValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a58a20 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView_OnValueChangedEvent__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

}
