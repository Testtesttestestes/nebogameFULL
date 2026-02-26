using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x0200094E RID: 2382
	[Token(Token = "0x200094E")]
	public class CombatUserBalanceItemRenderer : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x06003860 RID: 14432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003860")]
		[Address(RVA = "0x8817", Offset = "0x8817", VA = "0x8817")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_Players_CombatUserBalanceItemRenderer__OnDestroy
		               (int param1,double param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a566fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    DAT_ram_00a566fd = '\x01';
		  }
		  *(double *)(param1 + 0x18) = param2;
		  piVar2 = *(int **)(param1 + 0x14);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar1 = func_ii_8614(param2,0,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06003861 RID: 14433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003861")]
		[Address(RVA = "0x8818", Offset = "0x8818", VA = "0x8818")]
		public void SetValue(double value)
		{
		/* --- GHIDRA: SetValue ---
		void Gameplay_Combat_View_Players_CombatUserBalanceItemRenderer__SetValue
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  *(undefined4 *)(param1 + 0x20) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  param2_00 = func_ii_7611(param2,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003862 RID: 14434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003862")]
		[Address(RVA = "0x8819", Offset = "0x8819", VA = "0x8819")]
		public void SetResourcesDic(ResourcesDic dic)
		{
		/* --- GHIDRA: SetResourcesDic ---
		int Gameplay_Combat_View_Players_CombatUserBalanceItemRenderer__SetResourcesDic
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param3;
		  undefined4 param1_01;
		  double param1_02;
		  
		  if (DAT_ram_00a566fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2004);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a566fe = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_string__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,0,Method_UI_ToolTip_ToolTipData_string___ctor__);
		  param1_02 = *(double *)(param1 + 0x18);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  param3 = UI_SimpleIconValue__set_IconAssetId(param1_02,StringLiteral_28780,0);
		  if (*(int *)(param1 + 0x20) != 0) {
		    param1_01 = Core_Extensions_Dict_ResourcesDicExt__GetIconForPriceSpellInCombatAssetId
		                          (*(int *)(param1 + 0x20),0);
		    param3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                       (param1_01,StringLiteral_2004,param3,0);
		  }
		  *(undefined4 *)(param1_00 + 0x1c) = param3;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003863 RID: 14435 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003863")]
		[Address(RVA = "0x881A", Offset = "0x881A", VA = "0x881A", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003864")]
		[Address(RVA = "0x881B", Offset = "0x881B", VA = "0x881B")]
		public CombatUserBalanceItemRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Players_CombatUserBalanceItemRenderer___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  UnityEngine_Events_UnityEvent__GetDelegate(*(undefined4 *)(param1 + 0x10),0);
		  iVar1 = *(int *)(param1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001F34 RID: 7988
		[Token(Token = "0x4001F34")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001F35 RID: 7989
		[Token(Token = "0x4001F35")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _valueField;

		// Token: 0x04001F36 RID: 7990
		[Token(Token = "0x4001F36")]
		[FieldOffset(Offset = "0x18")]
		private double _value;

		// Token: 0x04001F37 RID: 7991
		[Token(Token = "0x4001F37")]
		[FieldOffset(Offset = "0x20")]
		private ResourcesDic _resourcesDic;
	}
}
