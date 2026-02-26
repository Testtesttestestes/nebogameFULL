using System;
using Core.Data.Effect;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Players.LongEffects
{
	// Token: 0x0200095A RID: 2394
	[Token(Token = "0x200095A")]
	[AddComponentMenu("Combat/LongEffectV2")]
	public class LongEffectV2 : LongEffect
	{
		// Token: 0x060038C8 RID: 14536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C8")]
		[Address(RVA = "0x8866", Offset = "0x8866", VA = "0x8866", Slot = "6")]
		protected override void SetupColor(EffectData data)
		{
		/* --- GHIDRA: SetupColor ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectV2__SetupColor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(0 < *(int *)(param2 + 0x18)),0);
		  return;
		}
		*/

		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C9")]
		[Address(RVA = "0x8867", Offset = "0x8867", VA = "0x8867", Slot = "7")]
		protected override void SetupVisibleStackValue(EffectData data)
		{
		/* --- GHIDRA: SetupVisibleStackValue ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectV2__SetupVisibleStackValue
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  param2_00 = Core_Extensions_Dict_EffectDictExt__GetIconAssetId(*(undefined4 *)(param2 + 8),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060038CA RID: 14538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038CA")]
		[Address(RVA = "0x8868", Offset = "0x8868", VA = "0x8868", Slot = "5")]
		protected override void SetupIcon(EffectData data)
		{
		/* --- GHIDRA: SetupIcon ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectV2__SetupIcon(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a56716 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28377);
		    DAT_ram_00a56716 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x2c) = StringLiteral_28377;
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x30) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060038CB RID: 14539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038CB")]
		[Address(RVA = "0x8869", Offset = "0x8869", VA = "0x8869")]
		public LongEffectV2()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectV2___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(*(int *)(*(int *)(param1 + 0x10) + 0x2c) != param2),0);
		  if (*(int *)(*(int *)(param1 + 0x10) + 0x2c) == param2) {
		    param2 = 0;
		  }
		  UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__get_Data
		            (*(int *)(param1 + 0x10),param2,0);
		  return;
		}
		*/

		}
	}
}
