using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000951 RID: 2385
	[Token(Token = "0x2000951")]
	public class NickBarCultFiller : MonoBehaviour
	{
		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003878 RID: 14456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B22")]
		public CultDic CultDic
		{
			[Token(Token = "0x6003877")]
			[Address(RVA = "0x8821", Offset = "0x8821", VA = "0x8821")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003878")]
			[Address(RVA = "0x8822", Offset = "0x8822", VA = "0x8822")]
			set
			{
			}
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003879")]
		[Address(RVA = "0x8823", Offset = "0x8823", VA = "0x8823", Slot = "4")]
		protected virtual void HandleCultDicChanged()
		{
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387A")]
		[Address(RVA = "0x8824", Offset = "0x8824", VA = "0x8824")]
		public void SetIconBackgroundAssetId(string assetId)
		{
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387B")]
		[Address(RVA = "0x8825", Offset = "0x8825", VA = "0x8825")]
		public void SetNickBackgroundAssetId(string assetId)
		{
		/* --- GHIDRA: SetNickBackgroundAssetId ---
		void Gameplay_Combat_View_Players_NickBarCultFiller__SetNickBackgroundAssetId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x18),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600387C RID: 14460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387C")]
		[Address(RVA = "0x8826", Offset = "0x8826", VA = "0x8826")]
		public void SetIconAssetId(string assetId)
		{
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387D")]
		[Address(RVA = "0x8827", Offset = "0x8827", VA = "0x8827")]
		public NickBarCultFiller()
		{
		}

		// Token: 0x04001F3A RID: 7994
		[Token(Token = "0x4001F3A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _iconBackground;

		// Token: 0x04001F3B RID: 7995
		[Token(Token = "0x4001F3B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _nickbackground;

		// Token: 0x04001F3C RID: 7996
		[Token(Token = "0x4001F3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001F3D RID: 7997
		[Token(Token = "0x4001F3D")]
		[FieldOffset(Offset = "0x1C")]
		private CultDic _cultDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CultDic ---
		void Gameplay_Combat_View_Players_NickBarCultFiller__get_CultDic
		               (int *param1,int param2,undefined4 param3)
		
		{
		  param1[7] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  return;
		}
		*/


		/* --- GHIDRA: set_CultDic ---
		void Gameplay_Combat_View_Players_NickBarCultFiller__set_CultDic(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a56702 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11326);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11327);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11324);
		    DAT_ram_00a56702 = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		          goto code_r0x80c6c916;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80c6c916:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    uVar3 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar3,StringLiteral_11326,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x18),uVar3,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		          goto code_r0x80c6c9e3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80c6c9e3:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    uVar3 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar3,StringLiteral_11324,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x10),uVar3,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		          goto code_r0x80c6cab0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80c6cab0:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    uVar3 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar3,StringLiteral_11327,0);
		  }
		  else {
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetDecorDotForAvatarFrameAssetId
		                      (*(int *)(param1 + 0x1c),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x18),uVar3,0);
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetIcon38x34AssetId(*(undefined4 *)(param1 + 0x1c),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x10),uVar3,0);
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetIcon46x52AssetId(*(undefined4 *)(param1 + 0x1c),0);
		  }
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x14),uVar3,0);
		  return;
		}
		*/

}
