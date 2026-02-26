using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x02000A01 RID: 2561
	[Token(Token = "0x2000A01")]
	public class UserRatingsRender : MonoBehaviour
	{
		// Token: 0x06003CF0 RID: 15600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF0")]
		[Address(RVA = "0x8BB0", Offset = "0x8BB0", VA = "0x8BB0")]
		public void RenderRatings(UserData user, Dictionaries dict)
		{
		/* --- GHIDRA: RenderRatings ---
		void Gameplay_Clans_Office_View_UserRatingsRender__RenderRatings(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f0b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameObject___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GameObject__TypeInfo);
		    DAT_ram_00a57f0b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_GameObject__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_GameObject___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF1")]
		[Address(RVA = "0x8BB1", Offset = "0x8BB1", VA = "0x8BB1")]
		public UserRatingsRender()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_UserRatingsRender___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  double param1_00;
		  int iVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57f0c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanInRatingListElement_ClanInRatingListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a57f0c = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0x1c);
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(*(int *)(iVar3 + 0x1c) + 0x18),0);
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  param1_00 = *(double *)(*(int *)(*(int *)(param1 + 0x18) + 0x24) + 0x10);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar1 = UI_SimpleIconValue__set_IconAssetId(param1_00,StringLiteral_28780,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar1 = *(undefined4 *)(param1 + 0x28);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x18) + 0x24) + 0x1c);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		  uVar1 = *(undefined4 *)(param1 + 0x34);
		  uVar2 = Core_Extensions_Dict_ClanLeagueDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 0x20),0);
		  AssetContent_GameImage__get_AssetId(uVar1,uVar2,0);
		  uVar1 = *(undefined4 *)(param1 + 0x38);
		  uVar2 = Core_Extensions_Dict_ClanLeagueDicExt__GetBanner2AssetId
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 0x20),0);
		  AssetContent_GameImage__get_AssetId(uVar1,uVar2,0);
		  uVar1 = *(undefined4 *)(param1 + 0x30);
		  uVar2 = Gameplay_World_Model_ClanData__ContainsCult(iVar3,0);
		  AssetContent_GameImage__get_AssetId(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x3c);
		  iVar3 = Gameplay_World_Model_ClanData__set_ClanLeagueDic
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(*(int *)(iVar3 + 0xc) != 0),0);
		  return;
		}
		*/

		}

		// Token: 0x040021CE RID: 8654
		[Token(Token = "0x40021CE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleIconValueBackground _ratingPointsRowPrefab;

		// Token: 0x040021CF RID: 8655
		[Token(Token = "0x40021CF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _ratingPointsContainer;

		// Token: 0x040021D0 RID: 8656
		[Token(Token = "0x40021D0")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<GameObject> _instances;
	}
}
