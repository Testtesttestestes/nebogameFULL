using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	public class PetToolTipView : BaseToolTip<PetData>
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x5D4D", Offset = "0x5D4D", VA = "0x5D4D", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_Combat_PetToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59987 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_PetData___ctor__);
		    DAT_ram_00a59987 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update(param1,Method_UI_ToolTip_BaseToolTip_PetData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x5D4E", Offset = "0x5D4E", VA = "0x5D4E")]
		public PetToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Combat_PetToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  int iVar7;
		  int param2_00;
		  int *piVar8;
		  longlong param2_01;
		  
		  param2_01 = (ulonglong)in_register_20000014 << 0x20;
		  param2_00 = 0;
		  if (DAT_ram_00a59988 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_SkillData____get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CombatSkillItemRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59988 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      uVar3 = (undefined4)((ulonglong)param2_01 >> 0x20);
		      iVar4 = *(int *)(iVar4 + param2_00 * 4 + 0x10);
		      uVar5 = *(undefined4 *)(param1 + 0x1c);
		      uVar6 = *(undefined4 *)(param1 + 0x18);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      uVar5 = func_ii_6805(uVar6,uVar5,
		                           Method_UnityEngine_Object_Instantiate_CombatSkillItemRenderer___);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *param1_00;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		            puVar2 = (uint *)(piVar8[1] * 8 + iVar7 + 0x178);
		            goto code_r0x8109a843;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8109a843:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(uVar3,puVar2[1]));
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      uVar3 = System_Collections_Generic_Dictionary_int__object___get_Item
		                        (uVar3,*(int *)(iVar4 + 8) + 1,0);
		      Google_Protobuf_Collections_RepeatedField_ulong___get_Item(uVar5,param2_00,0);
		      uVar6 = func_ii_7990(uVar3,0);
		      Core_Extensions_Dict_UserRatingKindDicExt__GetTitle(uVar5,uVar6,0);
		      uVar3 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar3,0);
		      Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId(uVar5,uVar3,0);
		      param2_01 = *(longlong *)(iVar4 + 0x10);
		      Gameplay_Combat_View_Players_CombatPlayerView__Gameplay_Combat_View_Players_ICombatPLayerView_get_gameObject
		                (uVar5,param2_01,(double)*(longlong *)(iVar4 + 0x18),0);
		      param2_00 = param2_00 + 1;
		      iVar4 = *(int *)(param1 + 0x14);
		    } while (param2_00 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/PetToolTipView";

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _subTitle;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _descriptionTitle;
	}
}
