using System;
using Core.Money;
using Gameplay.ResourceBar.View;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x0200051F RID: 1311
	[Token(Token = "0x200051F")]
	public class SmallGamesResourceRenderer : MonoBehaviour
	{
		// Token: 0x06001F35 RID: 7989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F35")]
		[Address(RVA = "0x709C", Offset = "0x709C", VA = "0x709C")]
		public void SetIndex(int index)
		{
		/* --- GHIDRA: SetIndex ---
		void Gameplay_SmallGames_View_SmallGamesResourceRenderer__SetIndex
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float8 local_8;
		  
		  if (DAT_ram_00a58673 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a58673 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  local_8 = *(float8 *)(param2 + 0x10);
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  uVar1 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		  uVar1 = System_Double__GetHashCode(&local_8,uVar1,0);
		  Gameplay_RegisterV2_View_RegistrationResourceView__set_IconAssetId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 8);
		  uVar1 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar2 = func_ii_7278(uVar2,0);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__GetValue(param3,uVar2,0);
		  uVar2 = System_Double__ToString(uVar2,0);
		  Gameplay_ResourceBar_View_ResourceBarIconValueView__get_IconAssetId(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F36")]
		[Address(RVA = "0x709D", Offset = "0x709D", VA = "0x709D")]
		public void Init(Money resource, Dictionaries dict)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_View_SmallGamesResourceRenderer__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a65c07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_MarshalledUnityObject_MarshalNotNull_Transform___);
		    DAT_ram_00a65c07 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a65c6c == 0) {
		      DAT_ram_00a65c6c = func_ii_2140(s_UnityEngine_Transform__SetAsFirs_ram_00064935);
		    }
		    (**(code **)((ulonglong)DAT_ram_00a65c6c * 4))(iVar2);
		    return;
		  }
		  unnamed_function_2232(&UnityEngine_Object_TypeInfo);
		  uVar1 = unnamed_function_2232(&System_NullReferenceException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  func_ii_20905(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&Method_UnityEngine_Bindings_ThrowHelper_ThrowNullReferenceException__);
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_View_SmallGamesResourceRenderer__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a65c07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_MarshalledUnityObject_MarshalNotNull_Transform___);
		    DAT_ram_00a65c07 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a65c6c == 0) {
		      DAT_ram_00a65c6c = func_ii_2140(s_UnityEngine_Transform__SetAsFirs_ram_00064935);
		    }
		    (**(code **)((ulonglong)DAT_ram_00a65c6c * 4))(iVar2);
		    return;
		  }
		  unnamed_function_2232(&UnityEngine_Object_TypeInfo);
		  uVar1 = unnamed_function_2232(&System_NullReferenceException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  func_ii_20905(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&Method_UnityEngine_Bindings_ThrowHelper_ThrowNullReferenceException__);
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_View_SmallGamesResourceRenderer__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a65c07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_MarshalledUnityObject_MarshalNotNull_Transform___);
		    DAT_ram_00a65c07 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a65c6c == 0) {
		      DAT_ram_00a65c6c = func_ii_2140(s_UnityEngine_Transform__SetAsFirs_ram_00064935);
		    }
		    (**(code **)((ulonglong)DAT_ram_00a65c6c * 4))(iVar2);
		    return;
		  }
		  unnamed_function_2232(&UnityEngine_Object_TypeInfo);
		  uVar1 = unnamed_function_2232(&System_NullReferenceException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  func_ii_20905(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&Method_UnityEngine_Bindings_ThrowHelper_ThrowNullReferenceException__);
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F37")]
		[Address(RVA = "0x709E", Offset = "0x709E", VA = "0x709E")]
		public void Init(ResourceSet resourceSet, Protocol.Consts.Resources resourceId, Dictionaries dict)
		{
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F38")]
		[Address(RVA = "0x1D14", Offset = "0x1D14", VA = "0x1D14")]
		public void Init(RewardInfo rewardInfo)
		{
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F39")]
		[Address(RVA = "0x709F", Offset = "0x709F", VA = "0x709F")]
		private void DetermineIcon(RewardTypes type)
		{
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x70A0", Offset = "0x70A0", VA = "0x70A0")]
		public SmallGamesResourceRenderer()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_SmallGames_View_SmallGamesResourceRenderer___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58677 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12667);
		    DAT_ram_00a58677 = '\x01';
		  }
		  return StringLiteral_12667;
		}
		*/

		}

		// Token: 0x040010F2 RID: 4338
		[Token(Token = "0x40010F2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceBarIconValueView _iconValueView;

		// Token: 0x040010F3 RID: 4339
		[Token(Token = "0x40010F3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x040010F4 RID: 4340
		[Token(Token = "0x40010F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _darkSprite;
	}
}
