using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009FD RID: 2557
	[Token(Token = "0x20009FD")]
	public class ClanRatingsGroup : MonoBehaviour
	{
		// Token: 0x06003CE4 RID: 15588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x8BA4", Offset = "0x8BA4", VA = "0x8BA4")]
		public void Init(Dictionaries dict)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_View_ClanRatingsGroup__Init
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 param1_00;
		  int param2_00;
		  int iVar5;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57f04 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanRatingKindDic__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanRatingKindDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a57f04 = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x264);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar3,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ClanRatingKindDic__get_Item__
		                        );
		      piVar4 = *(int **)(param2_00 * 4 + *(int *)(param1 + 0x18) + 0x10);
		      lVar2 = func_ii_7271(*(undefined4 *)(param3 + 0x24),*(int *)(iVar3 + 0xc) + -1,
		                           Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_StringUtils_TypeInfo);
		      }
		      uVar1 = UI_SimpleIconValue__set_IconAssetId((double)lVar2,StringLiteral_28780,0);
		      iVar5 = *piVar4;
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		                (piVar4,uVar1,*(undefined4 *)(iVar5 + 0xec));
		      param1_00 = *(undefined4 *)(*(int *)(param1 + 0x18) + param2_00 * 4 + 0x10);
		      uVar1 = Core_Extensions_Dict_ClanLeagueDicExt__GetIconAssetId(iVar3,0);
		      Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId(param1_00,uVar1,0);
		      param2_00 = param2_00 + 1;
		      iVar3 = *(int *)(param2 + 0x264);
		    } while (param2_00 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x8BA5", Offset = "0x8BA5", VA = "0x8BA5")]
		public void UpdateRatings(Dictionaries dict, ClanInfo info)
		{
		/* --- GHIDRA: UpdateRatings ---
		void Gameplay_Clans_Office_View_ClanRatingsGroup__UpdateRatings(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57f05 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_View_TitleIconValueBackground___TypeInfo);
		    DAT_ram_00a57f05 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_UserInfo_View_TitleIconValueBackground___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE6")]
		[Address(RVA = "0x8BA6", Offset = "0x8BA6", VA = "0x8BA6")]
		public ClanRatingsGroup()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Clans_Office_View_ClanRatingsGroup___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57f06 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57f06 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 == 0) {
		    uVar2 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		    *(undefined4 *)(param1 + 0x10) = uVar2;
		    return uVar2;
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  return uVar2;
		}
		*/

		}

		// Token: 0x040021C5 RID: 8645
		[Token(Token = "0x40021C5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleIconValueBackground _rowPrefab;

		// Token: 0x040021C6 RID: 8646
		[Token(Token = "0x40021C6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040021C7 RID: 8647
		[Token(Token = "0x40021C7")]
		[FieldOffset(Offset = "0x18")]
		private TitleIconValueBackground[] _ratingRows;
	}
}
