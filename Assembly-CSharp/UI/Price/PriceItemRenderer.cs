using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Price
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	public class PriceItemRenderer : MonoBehaviour
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x1700018B")]
		public Color32 IsOkColor
		{
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x5F00", Offset = "0x5F00", VA = "0x5F00")]
			get
			{
				return default(Color32);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x1700018C")]
		public Color32 IsNotOkColor
		{
			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x5F01", Offset = "0x5F01", VA = "0x5F01")]
			get
			{
				return default(Color32);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018D")]
		public virtual Func<Protocol.Consts.Resources, string> GetAssetIdHandler
		{
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x5F02", Offset = "0x5F02", VA = "0x5F02", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x5F03", Offset = "0x5F03", VA = "0x5F03", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018E")]
		public virtual Func<Money.MoneyType, string> GetMoneyAssetIdHandler
		{
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x5F04", Offset = "0x5F04", VA = "0x5F04", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x5F05", Offset = "0x5F05", VA = "0x5F05", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x5F06", Offset = "0x5F06", VA = "0x5F06")]
		private static string GetAssetIdHandlerDefault(Protocol.Consts.Resources resId)
		{
		/* --- GHIDRA: GetAssetIdHandlerDefault ---
		undefined4 UI_Price_PriceItemRenderer__GetAssetIdHandlerDefault(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a638e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a638e4 = '\x01';
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
		        goto code_r0x82314848;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82314848:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  param2_00 = func_ii_7278(param1,0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar3,param2_00,0);
		  uVar3 = func_ii_7611(uVar3,0);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: GetAssetIdHandlerDefault ---
		undefined4 UI_Price_PriceItemRenderer__GetAssetIdHandlerDefault(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a638e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a638e4 = '\x01';
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
		        goto code_r0x82314848;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82314848:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  param2_00 = func_ii_7278(param1,0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar3,param2_00,0);
		  uVar3 = func_ii_7611(uVar3,0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x5F07", Offset = "0x5F07", VA = "0x5F07")]
		private static string GetAssetIdHandlerDefault(Money.MoneyType moneyType)
		{
			return null;
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00003D68 File Offset: 0x00001F68
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018F")]
		public bool ValidIconEnabled
		{
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x5F08", Offset = "0x5F08", VA = "0x5F08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x1F8B", Offset = "0x1F8B", VA = "0x1F8B")]
			set
			{
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x5F09", Offset = "0x5F09", VA = "0x5F09")]
		private void HandleValidIconEnabledChanged()
		{
		/* --- GHIDRA: HandleValidIconEnabledChanged ---
		void UI_Price_PriceItemRenderer__HandleValidIconEnabledChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  func_ii_7050(*(undefined4 *)(param1 + 0x10),param2,0);
		  local_8 = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  iVar1 = **(int **)(param1 + 0x10);
		  local_18 = 0x3f8000003f800000;
		  local_20 = 0x3f8000003f800000;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x10),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x5F0A", Offset = "0x5F0A", VA = "0x5F0A")]
		public void SetIcon(Sprite value)
		{
		/* --- GHIDRA: SetIcon ---
		void UI_Price_PriceItemRenderer__SetIcon(int param1,undefined4 param2,undefined4 param3)
		
		{
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x5F0B", Offset = "0x5F0B", VA = "0x5F0B")]
		public void SetIconAssetId(string assetId)
		{
		/* --- GHIDRA: SetIconAssetId ---
		undefined4 UI_Price_PriceItemRenderer__SetIconAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a638e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources__get_HasValue__);
		    DAT_ram_00a638e5 = '\x01';
		  }
		  if ((*(ulonglong *)(param1 + 0x30) & 0xff) != 0) {
		    return (int)(*(ulonglong *)(param1 + 0x30) >> 0x20);
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    }
		    param1_00 = Utils_MathUtils_MathUtils__SaferDivide(0,0);
		  }
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar1 = func_ii_7278(param1_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00003D80 File Offset: 0x00001F80
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000190")]
		public Protocol.Consts.Resources ResId
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x5F0C", Offset = "0x5F0C", VA = "0x5F0C")]
			get
			{
				return Protocol.Consts.Resources.UnknownResource;
			}
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x1F89", Offset = "0x1F89", VA = "0x1F89")]
			set
			{
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000191")]
		public Money.MoneyType MoneyType
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x5F0D", Offset = "0x5F0D", VA = "0x5F0D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x1F88", Offset = "0x1F88", VA = "0x1F88")]
			set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000192")]
		public bool TruncatePrice
		{
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x5F0E", Offset = "0x5F0E", VA = "0x5F0E")]
			set
			{
			}
		}

		// Token: 0x17000193 RID: 403
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000193")]
		public double Value
		{
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x1F8C", Offset = "0x1F8C", VA = "0x1F8C")]
			set
			{
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x5F0F", Offset = "0x5F0F", VA = "0x5F0F")]
		public void SetIsOk(bool value)
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x1F8A", Offset = "0x1F8A", VA = "0x1F8A")]
		public void SetColor(in Color32 color)
		{
		/* --- GHIDRA: SetColor ---
		void UI_Price_PriceItemRenderer__SetColor(int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (param2 != *(byte *)(param1 + 0x2c)) {
		    *(char *)(param1 + 0x2c) = (char)param2;
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)*(byte *)(param1 + 0x2c),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x5F10", Offset = "0x5F10", VA = "0x5F10")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Price_PriceItemRenderer__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a638e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_Money_MoneyType__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Resources__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_PriceItemRenderer_GetAssetIdHandlerDefault__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_PriceItemRenderer_GetAssetIdHandlerDefault__);
		    DAT_ram_00a638e9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_Resources__string__TypeInfo);
		  func_ii_8070(uVar1,0,Method_UI_Price_PriceItemRenderer_GetAssetIdHandlerDefault__,0);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Func_Money_MoneyType__string__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,0,Method_UI_Price_PriceItemRenderer_GetAssetIdHandlerDefault__,0);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x5F11", Offset = "0x5F11", VA = "0x5F11")]
		public PriceItemRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Price_PriceItemRenderer___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x38),0);
		  return;
		}
		*/

		}

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _validIcon;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _valueFiled;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Sprite _isOk;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _isNotOk;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color32 _isOkColor;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color32 _isNotOkColor;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x2C")]
		private bool _validIconEnabled;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x30")]
		private Protocol.Consts.Resources? _resId;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x38")]
		private Money.MoneyType _moneyType;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x44")]
		private bool _truncatePrice;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsOkColor ---
		void UI_Price_PriceItemRenderer__get_IsOkColor(undefined4 *param1,int param2,undefined4 param3)
		
		{
		  *param1 = *(undefined4 *)(param2 + 0x28);
		  return;
		}
		*/


		/* --- GHIDRA: set_GetMoneyAssetIdHandler ---
		undefined4
		UI_Price_PriceItemRenderer__set_GetMoneyAssetIdHandler(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a638e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a638e3 = '\x01';
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
		        goto code_r0x8231475e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8231475e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar3,param1,0);
		  uVar3 = func_ii_7611(uVar3,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_ValidIconEnabled ---
		void UI_Price_PriceItemRenderer__get_ValidIconEnabled(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x2c),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_ValidIconEnabled ---
		void UI_Price_PriceItemRenderer__set_ValidIconEnabled(int param1,double param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a638e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a638e8 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x18);
		  if (*(char *)(param1 + 0x44) == '\0') {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar2 = UI_SimpleIconValue__set_IconAssetId(param2,StringLiteral_28780,0);
		    uVar1 = (undefined4)((ulonglong)param2 >> 0x20);
		  }
		  else {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar2 = func_ii_8614(param2,0,0);
		    uVar1 = (undefined4)((ulonglong)param2 >> 0x20);
		  }
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (CONCAT44(uVar1,piVar3),uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: get_ResId ---
		int UI_Price_PriceItemRenderer__get_ResId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  ulonglong uVar2;
		  
		  if (DAT_ram_00a638e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources__get_HasValue__);
		    DAT_ram_00a638e7 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x38);
		  if (iVar1 == 0) {
		    uVar2 = *(ulonglong *)(param1 + 0x30);
		    if ((uVar2 & 0xff) == 0) {
		      return 0;
		    }
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    }
		    iVar1 = Utils_MathUtils_MathUtils__SaferDivide((int)(uVar2 >> 0x20),0);
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: set_ResId ---
		void UI_Price_PriceItemRenderer__set_ResId(int param1,uint *param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar2 = *param2;
		  local_8 = (float4)((float)(uVar2 >> 0x10 & 0xff) / 255.0);
		  local_4 = (float4)((float)(uVar2 >> 0x18) / 255.0);
		  local_10 = (float4)((float)(uVar2 & 0xff) / 255.0);
		  local_c = (float4)((float)(uVar2 >> 8 & 0xff) / 255.0);
		  iVar1 = **(int **)(param1 + 0x18);
		  local_18 = CONCAT44(local_4,local_8);
		  local_20 = CONCAT44(local_c,local_10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x18),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/


		/* --- GHIDRA: set_MoneyType ---
		void UI_Price_PriceItemRenderer__set_MoneyType(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a638e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources__get_HasValue__);
		    DAT_ram_00a638e6 = '\x01';
		  }
		  if ((*(ulonglong *)(param1 + 0xc) & 0xff) == 0 ||
		      (int)(*(ulonglong *)(param1 + 0xc) >> 0x20) != param2) {
		    local_8 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor(&local_8,param2,Method_System_Nullable_Resources___ctor__);
		    *(undefined8 *)(param1 + 0xc) = local_8;
		    param1_00 = param1[4];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                          (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    AssetContent_GameImage__get_AssetId(param1_00,param2_00,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_TruncatePrice ---
		void UI_Price_PriceItemRenderer__set_TruncatePrice(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x1c;
		  if (param2 == 0) {
		    iVar1 = 0x20;
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + iVar1),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Value ---
		int * UI_Price_PriceItemRenderer__set_Value(int *param1)
		
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
