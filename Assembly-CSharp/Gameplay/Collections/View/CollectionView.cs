using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C8 RID: 2504
	[Token(Token = "0x20009C8")]
	public class CollectionView : MonoBehaviour
	{
		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06003C00 RID: 15360 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		// (set) Token: 0x06003C01 RID: 15361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD6")]
		public bool IgnoreAchieved
		{
			[Token(Token = "0x6003C00")]
			[Address(RVA = "0x8AD1", Offset = "0x8AD1", VA = "0x8AD1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003C01")]
			[Address(RVA = "0x214E", Offset = "0x214E", VA = "0x214E")]
			set
			{
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06003C02 RID: 15362 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003C03 RID: 15363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD7")]
		public CollectionData Data
		{
			[Token(Token = "0x6003C02")]
			[Address(RVA = "0x8AD2", Offset = "0x8AD2", VA = "0x8AD2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C03")]
			[Address(RVA = "0x8AD3", Offset = "0x8AD3", VA = "0x8AD3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C04")]
		[Address(RVA = "0x214F", Offset = "0x214F", VA = "0x214F")]
		public void SetInfo(CollectionData data, UserData user, uint rankToShow)
		{
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C05")]
		[Address(RVA = "0x8AD4", Offset = "0x8AD4", VA = "0x8AD4")]
		public CollectionView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_View_CollectionView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57e8e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionViewClickable_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57e8e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Collections_View_CollectionViewClickable_ButtonClickedEventHandler__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0400211D RID: 8477
		[Token(Token = "0x400211D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400211E RID: 8478
		[Token(Token = "0x400211E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _rank;

		// Token: 0x0400211F RID: 8479
		[Token(Token = "0x400211F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x04002120 RID: 8480
		[Token(Token = "0x4002120")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected CollectionIconView _collectionIcon;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IgnoreAchieved ---
		void Gameplay_Collections_View_CollectionView__set_IgnoreAchieved
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  int iVar6;
		  float param2_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57e8d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    DAT_ram_00a57e8d = '\x01';
		  }
		  local_4 = 0;
		  *(int *)(param1 + 0x20) = param2;
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = System_Xml_XsdCachingReader__get_Name(param2,0);
		  uVar2 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetAvatarRibbonAssetId(uVar2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar4 = Utils_SetAsFirstSibling___ctor(param4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar4,0);
		  iVar5 = *(int *)(param1 + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e7017b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e7017b:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(iVar5 + 0x24) = param3;
		  *(undefined4 *)(iVar5 + 0x20) = uVar2;
		  if ((*(char *)(iVar5 + 0x31) == '\0') && (*(char *)(iVar5 + 0x30) == '\0')) {
		    param2_00 = 1.0;
		  }
		  else {
		    param2_00 = 0.0;
		  }
		  AssetContent_GameAssetViewRawImage__TryGetCurrentContent
		            (*(undefined4 *)(iVar5 + 0x1c),param2_00,0);
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(iVar5 + 0x18),param2_00,0);
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(iVar5 + 0x10),param2_00,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  iVar5 = *(int *)(param1 + 0x1c);
		  *(undefined4 *)(iVar5 + 0x2c) = param4;
		  *(undefined4 *)(iVar5 + 0x28) = uVar2;
		  Gameplay_Collections_View_CollectionIconView__get_Rank(iVar5,iVar5);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar5 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if ((iVar5 != 0) &&
		     (iVar5 = Gameplay_Collections_Model_CollectionDicGroup__GetCollectionRanksDic
		                        (*(undefined4 *)(param2 + 0x18),param4,&local_4,uVar2), iVar5 != 0)) {
		    uVar4 = *(undefined4 *)(param1 + 0x18);
		    uVar2 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetQuadBackgroundAssetId(local_4,0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (uVar4,uVar2,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		  }
		  return;
		}
		*/

}
