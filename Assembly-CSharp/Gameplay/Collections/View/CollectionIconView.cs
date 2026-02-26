using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009BF RID: 2495
	[Token(Token = "0x20009BF")]
	public class CollectionIconView : MonoBehaviour
	{
		// Token: 0x06003BBF RID: 15295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBF")]
		[Address(RVA = "0x8A95", Offset = "0x8A95", VA = "0x8A95")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC0")]
		[Address(RVA = "0x1AA4", Offset = "0x1AA4", VA = "0x1AA4")]
		public void Init(IDictProvider dictProvider, UserData user)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Collections_View_CollectionIconView__Init(int param1,uint param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  uVar1 = Gameplay_Collections_View_CollectionMedalView___ctor(*(undefined4 *)(param1 + 0x18),0);
		  if (uVar1 < param2) {
		    param2 = Gameplay_Collections_View_CollectionMedalView___ctor(*(undefined4 *)(param1 + 0x18),0);
		  }
		  *(uint *)(param1 + 0x1c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06003BC1 RID: 15297 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003BC2 RID: 15298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC9")]
		public CollectionData Data
		{
			[Token(Token = "0x6003BC1")]
			[Address(RVA = "0x8A96", Offset = "0x8A96", VA = "0x8A96")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BC2")]
			[Address(RVA = "0x8A97", Offset = "0x8A97", VA = "0x8A97")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06003BC3 RID: 15299 RVA: 0x0000C060 File Offset: 0x0000A260
		// (set) Token: 0x06003BC4 RID: 15300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCA")]
		public uint Rank
		{
			[Token(Token = "0x6003BC3")]
			[Address(RVA = "0x8A98", Offset = "0x8A98", VA = "0x8A98")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6003BC4")]
			[Address(RVA = "0x1AA6", Offset = "0x1AA6", VA = "0x1AA6")]
			set
			{
			}
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC5")]
		[Address(RVA = "0x8A99", Offset = "0x8A99", VA = "0x8A99")]
		private void HandleRankChanged()
		{
		/* --- GHIDRA: HandleRankChanged ---
		void Gameplay_Collections_View_CollectionIconView__HandleRankChanged
		               (int param1,undefined4 param2,undefined4 param3,undefined8 *param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a57e69 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a57e69 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 0x1c),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  local_8 = *(undefined4 *)(param4 + 1);
		  local_10 = *param4;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_10,0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(param1 + 0x1c),param2,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  uVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param5,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar2 ^ 1,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x14),param5,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  uVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param6,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar2 ^ 1,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x18),param6,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x10),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC6")]
		[Address(RVA = "0x8A9A", Offset = "0x8A9A", VA = "0x8A9A")]
		private void Draw([NotNull] string iconAssetId, [NotNull] string rankFrameAssetId, Vector3 scale, [CanBeNull] string ribbonAssetId, [CanBeNull] string rankBackgroundAssetId)
		{
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x0000C078 File Offset: 0x0000A278
		// (set) Token: 0x06003BC8 RID: 15304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCB")]
		public bool IgnoreAchieved
		{
			[Token(Token = "0x6003BC7")]
			[Address(RVA = "0x8A9B", Offset = "0x8A9B", VA = "0x8A9B")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BC8")]
			[Address(RVA = "0x8A9C", Offset = "0x8A9C", VA = "0x8A9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06003BC9 RID: 15305 RVA: 0x0000C090 File Offset: 0x0000A290
		// (set) Token: 0x06003BCA RID: 15306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCC")]
		public bool Achieved
		{
			[Token(Token = "0x6003BC9")]
			[Address(RVA = "0x8A9D", Offset = "0x8A9D", VA = "0x8A9D")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BCA")]
			[Address(RVA = "0x8A9E", Offset = "0x8A9E", VA = "0x8A9E")]
			set
			{
			}
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0x8A9F", Offset = "0x8A9F", VA = "0x8A9F")]
		private void HandleAchivedChanged()
		{
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCC")]
		[Address(RVA = "0x8AA0", Offset = "0x8AA0", VA = "0x8AA0")]
		public CollectionIconView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Collections_View_CollectionIconView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e6a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12599);
		    DAT_ram_00a57e6a = '\x01';
		  }
		  return StringLiteral_12599;
		}
		*/

		}

		// Token: 0x040020E7 RID: 8423
		[Token(Token = "0x40020E7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _rankFrame;

		// Token: 0x040020E8 RID: 8424
		[Token(Token = "0x40020E8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _ribbon;

		// Token: 0x040020E9 RID: 8425
		[Token(Token = "0x40020E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _rankbackground;

		// Token: 0x040020EA RID: 8426
		[Token(Token = "0x40020EA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameAssetViewRawImage _iconAssetView;

		// Token: 0x040020EB RID: 8427
		[Token(Token = "0x40020EB")]
		private const int MEDAL_ICON_SIZE = 64;

		// Token: 0x040020EC RID: 8428
		[Token(Token = "0x40020EC")]
		private const int APR_ICON_SIZE = 90;

		// Token: 0x040020ED RID: 8429
		[Token(Token = "0x40020ED")]
		private const int DEFAULT_SIZE = 128;

		// Token: 0x040020EE RID: 8430
		[Token(Token = "0x40020EE")]
		[FieldOffset(Offset = "0x20")]
		private IDictProvider _dictProvider;

		// Token: 0x040020EF RID: 8431
		[Token(Token = "0x40020EF")]
		[FieldOffset(Offset = "0x24")]
		private UserData _user;

		// Token: 0x040020F1 RID: 8433
		[Token(Token = "0x40020F1")]
		[FieldOffset(Offset = "0x2C")]
		private uint _rank;

		// Token: 0x040020F3 RID: 8435
		[Token(Token = "0x40020F3")]
		[FieldOffset(Offset = "0x31")]
		private bool _achieved;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Rank ---
		void Gameplay_Collections_View_CollectionIconView__get_Rank(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  uint param2_00;
		  float fVar6;
		  float fVar7;
		  float fVar8;
		  undefined4 param2_01;
		  undefined8 local_40;
		  float local_38;
		  undefined8 local_30;
		  float local_28;
		  float4 local_20;
		  float4 local_1c;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  float4 local_c;
		  int local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57e68 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a57e68 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  if (*(char *)(param1 + 0x30) == '\0') {
		    param2_00 = *(uint *)(param1 + 0x2c);
		    bVar1 = *(uint *)(*(int *)(param1 + 0x28) + 0x1c) < param2_00;
		  }
		  else {
		    param2_00 = *(uint *)(param1 + 0x2c);
		    bVar1 = false;
		  }
		  iVar2 = Gameplay_Collections_Model_CollectionDicGroup__GetCollectionRanksDic
		                    (*(undefined4 *)(*(int *)(param1 + 0x28) + 0x18),param2_00,&local_4,param1);
		  if (iVar2 != 0) {
		    uVar3 = Core_Data_CollectionData__get_NextRank(*(undefined4 *)(param1 + 0x28),0);
		    param2_01 = *(undefined4 *)(param1 + 0x20);
		    uVar4 = func_ii_6965(*(undefined4 *)(param1 + 0x24),0);
		    uVar5 = Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__uint___GetWrapper
		                      (*(undefined4 *)(param1 + 0x24),0);
		    iVar2 = Core_Extensions_Dict_MedalDicExt__GetDescription(uVar3,param2_01,uVar4,uVar5,&local_8,0)
		    ;
		    if (iVar2 == 0) {
		      uVar3 = Core_Data_CollectionData__get_CurrentMedalDic(*(undefined4 *)(param1 + 0x28),0);
		      uVar3 = Core_Extensions_Dict_LocalNotificationDicExt__GetBody(uVar3,0);
		      if (bVar1) {
		        uVar4 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0x14);
		      }
		      else {
		        uVar4 = Core_Extensions_Dict_ClanWarResultDicExt__GetBannerAssetId(local_4,0);
		      }
		      if (DAT_ram_00a6501f == '\0') {
		        Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		        DAT_ram_00a6501f = '\x01';
		      }
		      iVar2 = *(int *)(UnityEngine_Vector3_TypeInfo + 0x5c);
		      fVar6 = *(float *)(iVar2 + 0x10);
		      fVar7 = *(float *)(iVar2 + 0x14);
		      fVar8 = *(float *)(iVar2 + 0xc);
		      uVar5 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetAprFrameAssetId(local_4,0);
		      local_28 = fVar7 * 64.0 * 0.0078125;
		      local_20 = (float4)(fVar8 * 64.0 * 0.0078125);
		      local_1c = (float4)(fVar6 * 64.0 * 0.0078125);
		      local_30 = CONCAT44(local_1c,local_20);
		      local_18 = (float4)local_28;
		      Gameplay_Collections_View_CollectionIconView__HandleRankChanged
		                (param1,uVar3,uVar4,&local_30,0,uVar5,param1);
		    }
		    else {
		      uVar3 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(local_8 + 0x10),0);
		      if (bVar1) {
		        uVar4 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0x10);
		      }
		      else {
		        uVar4 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetFrameAssetId(local_4,0);
		      }
		      if (DAT_ram_00a6501f == '\0') {
		        Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		        DAT_ram_00a6501f = '\x01';
		      }
		      iVar2 = *(int *)(UnityEngine_Vector3_TypeInfo + 0x5c);
		      fVar6 = *(float *)(iVar2 + 0x10);
		      fVar7 = *(float *)(iVar2 + 0x14);
		      fVar8 = *(float *)(iVar2 + 0xc);
		      uVar5 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetAprRibbonAssetId(local_4,0);
		      local_38 = fVar7 * 90.0 * 0.0078125;
		      local_14 = (float4)(fVar8 * 90.0 * 0.0078125);
		      local_10 = (float4)(fVar6 * 90.0 * 0.0078125);
		      local_40 = CONCAT44(local_10,local_14);
		      local_c = (float4)local_38;
		      Gameplay_Collections_View_CollectionIconView__HandleRankChanged
		                (param1,uVar3,uVar4,&local_40,uVar5,0,param1);
		    }
		  }
		  bVar1 = *(uint *)(param1 + 0x2c) <= *(uint *)(*(int *)(param1 + 0x28) + 0x1c);
		  if (bVar1 != (bool)*(char *)(param1 + 0x31)) {
		    *(bool *)(param1 + 0x31) = bVar1;
		    if ((bVar1) || (*(char *)(param1 + 0x30) != '\0')) {
		      fVar6 = 0.0;
		    }
		    else {
		      fVar6 = 1.0;
		    }
		    AssetContent_GameAssetViewRawImage__TryGetCurrentContent(*(undefined4 *)(param1 + 0x1c),fVar6,0)
		    ;
		    Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x18),fVar6,0);
		    Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x10),fVar6,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Achieved ---
		void Gameplay_Collections_View_CollectionIconView__get_Achieved
		               (int param1,uint param2,undefined4 param3)
		
		{
		  float param2_00;
		  
		  if (param2 != *(byte *)(param1 + 0x31)) {
		    *(char *)(param1 + 0x31) = (char)param2;
		    if ((param2 == 0) && (*(char *)(param1 + 0x30) == '\0')) {
		      param2_00 = 1.0;
		    }
		    else {
		      param2_00 = 0.0;
		    }
		    AssetContent_GameAssetViewRawImage__TryGetCurrentContent
		              (*(undefined4 *)(param1 + 0x1c),param2_00,0);
		    Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x18),param2_00,0);
		    Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x10),param2_00,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Achieved ---
		void Gameplay_Collections_View_CollectionIconView__set_Achieved(int param1,undefined4 param2)
		
		{
		  float param2_00;
		  
		  if ((*(char *)(param1 + 0x31) == '\0') && (*(char *)(param1 + 0x30) == '\0')) {
		    param2_00 = 1.0;
		  }
		  else {
		    param2_00 = 0.0;
		  }
		  AssetContent_GameAssetViewRawImage__TryGetCurrentContent
		            (*(undefined4 *)(param1 + 0x1c),param2_00,0);
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x18),param2_00,0);
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x10),param2_00,0);
		  return;
		}
		*/

}
