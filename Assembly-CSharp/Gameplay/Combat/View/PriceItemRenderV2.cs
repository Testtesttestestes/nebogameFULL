using System;
using System.Runtime.CompilerServices;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Price;

namespace Gameplay.Combat.View
{
	// Token: 0x02000923 RID: 2339
	[Token(Token = "0x2000923")]
	public class PriceItemRenderV2 : PriceItemRenderer
	{
		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE3")]
		public override Func<Resources, string> GetAssetIdHandler
		{
			[Token(Token = "0x6003721")]
			[Address(RVA = "0x8710", Offset = "0x8710", VA = "0x8710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003722")]
			[Address(RVA = "0x8711", Offset = "0x8711", VA = "0x8711", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003724 RID: 14116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE4")]
		public override Func<Money.MoneyType, string> GetMoneyAssetIdHandler
		{
			[Token(Token = "0x6003723")]
			[Address(RVA = "0x8712", Offset = "0x8712", VA = "0x8712", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003724")]
			[Address(RVA = "0x8713", Offset = "0x8713", VA = "0x8713", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003725")]
		[Address(RVA = "0x8714", Offset = "0x8714", VA = "0x8714")]
		private static string GetAssetResIcon(Resources resId)
		{
		/* --- GHIDRA: GetAssetResIcon ---
		void Gameplay_Combat_View_PriceItemRenderV2__GetAssetResIcon(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a566a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_Money_MoneyType__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Resources__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_PriceItemRenderV2_GetAssetResIcon__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_PriceItemRenderV2_GetAssetResIcon__);
		    DAT_ram_00a566a2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_Resources__string__TypeInfo);
		  func_ii_8070(uVar1,0,Method_Gameplay_Combat_View_PriceItemRenderV2_GetAssetResIcon__,0);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  uVar1 = unnamed_function_1417(System_Func_Money_MoneyType__string__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,0,Method_Gameplay_Combat_View_PriceItemRenderV2_GetAssetResIcon__,0);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  UI_Price_PriceItemRenderer__OnDestroy(param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: GetAssetResIcon ---
		void Gameplay_Combat_View_PriceItemRenderV2__GetAssetResIcon(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a566a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_Money_MoneyType__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Resources__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_PriceItemRenderV2_GetAssetResIcon__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_PriceItemRenderV2_GetAssetResIcon__);
		    DAT_ram_00a566a2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_Resources__string__TypeInfo);
		  func_ii_8070(uVar1,0,Method_Gameplay_Combat_View_PriceItemRenderV2_GetAssetResIcon__,0);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  uVar1 = unnamed_function_1417(System_Func_Money_MoneyType__string__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,0,Method_Gameplay_Combat_View_PriceItemRenderV2_GetAssetResIcon__,0);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  UI_Price_PriceItemRenderer__OnDestroy(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003726")]
		[Address(RVA = "0x8715", Offset = "0x8715", VA = "0x8715")]
		private static string GetAssetResIcon(Money.MoneyType moneyType)
		{
			return null;
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003727")]
		[Address(RVA = "0x8716", Offset = "0x8716", VA = "0x8716")]
		public PriceItemRenderV2()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_GetMoneyAssetIdHandler ---
		undefined4
		Gameplay_Combat_View_PriceItemRenderV2__set_GetMoneyAssetIdHandler
		          (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a566a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a566a0 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80c62968;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80c62968:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar3,param1,0);
		  uVar3 = Core_Extensions_Dict_ResourcesDicExt__GetIcon256AssetId(uVar3,0);
		  return uVar3;
		}
		*/

}
