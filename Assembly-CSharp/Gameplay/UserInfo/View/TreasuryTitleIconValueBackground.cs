using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	public class TreasuryTitleIconValueBackground : TitleIconValueBackground, IToolTipDataProvider
	{
		// Token: 0x14000117 RID: 279
		// (add) Token: 0x06001810 RID: 6160 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001811 RID: 6161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000117")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6001810")]
			[Address(RVA = "0x69C7", Offset = "0x69C7", VA = "0x69C7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x4462", Offset = "0x4462", VA = "0x4462")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000118 RID: 280
		// (add) Token: 0x06001812 RID: 6162 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001813 RID: 6163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000118")]
		public event Func<Protocol.Consts.Resources, BaseToolTipData> GetTooltipData
		{
			[Token(Token = "0x6001812")]
			[Address(RVA = "0x69C8", Offset = "0x69C8", VA = "0x69C8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x4463", Offset = "0x4463", VA = "0x4463")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x69C9", Offset = "0x69C9", VA = "0x69C9")]
		public void SetResourceId(Protocol.Consts.Resources resourceId)
		{
		/* --- GHIDRA: SetResourceId ---
		void Gameplay_UserInfo_View_TreasuryTitleIconValueBackground__SetResourceId
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a598ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_TreasuryTitleIconValueBackground_MarkerClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a598ef = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_View_TreasuryTitleIconValueBackground_MarkerClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x17000433 RID: 1075
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000433")]
		public bool Marked
		{
			[Token(Token = "0x6001815")]
			[Address(RVA = "0x4465", Offset = "0x4465", VA = "0x4465")]
			set
			{
			}
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x69CA", Offset = "0x69CA", VA = "0x69CA")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_UserInfo_View_TreasuryTitleIconValueBackground__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a598f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_TreasuryTitleIconValueBackground_MarkerClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a598f0 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_View_TreasuryTitleIconValueBackground_MarkerClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001817")]
		[Address(RVA = "0x69CB", Offset = "0x69CB", VA = "0x69CB")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x69CC", Offset = "0x69CC", VA = "0x69CC")]
		private void MarkerClickedEventHandler()
		{
		/* --- GHIDRA: MarkerClickedEventHandler ---
		undefined4
		Gameplay_UserInfo_View_TreasuryTitleIconValueBackground__MarkerClickedEventHandler
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x40);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param1 + 0x44),
		                     *(undefined4 *)(iVar2 + 0x14));
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x69CD", Offset = "0x69CD", VA = "0x69CD", Slot = "6")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x69CE", Offset = "0x69CE", VA = "0x69CE")]
		public TreasuryTitleIconValueBackground()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_UserInfo_View_TreasuryTitleIconValueBackground___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a598f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12682);
		    DAT_ram_00a598f1 = '\x01';
		  }
		  return StringLiteral_12682;
		}
		*/

		}

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _marker;

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x44")]
		private Protocol.Consts.Resources _resourceId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_UserInfo_View_TreasuryTitleIconValueBackground__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a598ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_Resources__BaseToolTipData__TypeInfo);
		    DAT_ram_00a598ed = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Func_Resources__BaseToolTipData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_Resources__BaseToolTipData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_UserInfo_View_TreasuryTitleIconValueBackground__remove_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a598ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_Resources__BaseToolTipData__TypeInfo);
		    DAT_ram_00a598ee = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Func_Resources__BaseToolTipData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_Resources__BaseToolTipData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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


		/* --- GHIDRA: set_Marked ---
		int * Gameplay_UserInfo_View_TreasuryTitleIconValueBackground__set_Marked(int *param1)
		
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
