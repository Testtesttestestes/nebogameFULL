using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D90 RID: 3472
	[Token(Token = "0x2000D90")]
	internal class EffectData
	{
		// Token: 0x060054F1 RID: 21745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F1")]
		[Address(RVA = "0xA297", Offset = "0xA297", VA = "0xA297")]
		public EffectData(Antiq.Types.EffectsDic effectsDic, ArtifactData artifact, ReadOnlyCollection<Antiq.Types.EffectsDic.Types.EffectStringValueDic> effectValueStrings)
		{
		/* --- GHIDRA: .ctor ---
		undefined8 Core_Data_Effect_EffectData___ctor(int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  
		  if (DAT_ram_00a60841 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    DAT_ram_00a60841 = '\x01';
		  }
		  uVar1 = func_ii_7271(*(undefined4 *)(*(int *)(param1 + 0xc) + 0x14),1,
		                       Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Antiq_Model_EffectData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a594a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Antiq_Model_EffectData__GetIntegerValue_b__4_0__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_RewardInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RewardInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_RewardInfo__bool__TypeInfo);
		    DAT_ram_00a594a5 = '\x01';
		  }
		  uVar1 = Gameplay_Antiq_Model_ArtifactData___ctor(*(undefined4 *)(param1 + 0x10),param1);
		  param1_00 = unnamed_function_1417(System_Func_RewardInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,param1,Method_Gameplay_Antiq_Model_EffectData__GetIntegerValue_b__4_0__,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Where_RewardInfo___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		  iVar2 = System_Linq_Enumerable__Count_object_
		                    (uVar1,Method_System_Linq_Enumerable_First_RewardInfo___);
		  uVar1 = System_Linq_Enumerable__Last_object_
		                    (*(undefined4 *)(iVar2 + 0x10),Method_System_Linq_Enumerable_Last_uint___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x60054F2")]
		[Address(RVA = "0xA298", Offset = "0xA298", VA = "0xA298")]
		public uint GetIntegerValue()
		{
		/* --- GHIDRA: GetIntegerValue ---
		undefined4 Gameplay_Antiq_Model_EffectData__GetIntegerValue(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a594a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_First_Antiq_Types_EffectsDic_Types_EffectStringValueDic___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_Antiq_Types_EffectsDic_Types_EffectStringValueDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Model_EffectData___c__DisplayClass5_0__GetValue_b__0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Model_EffectData___c__DisplayClass5_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28583);
		    DAT_ram_00a594a6 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_Antiq_Model_EffectData___c__DisplayClass5_0_TypeInfo);
		  local_8 = Gameplay_Antiq_Model_EffectData___ctor(param1,param1);
		  *(undefined4 *)(param2_00 + 8) = local_8;
		  iVar2 = *(int *)(*(int *)(param1 + 0xc) + 0x1c);
		  if (iVar2 == 1) {
		    local_4 = local_8;
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar1 = func_ii_4419(StringLiteral_28579,uVar1,0);
		  }
		  else if (iVar2 == 2) {
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar1 = func_ii_4419(StringLiteral_28583,uVar1,0);
		  }
		  else if (iVar2 == 3) {
		    param1_00 = *(undefined4 *)(param1 + 8);
		    uVar1 = unnamed_function_1417
		                      (System_Func_Antiq_Types_EffectsDic_Types_EffectStringValueDic__bool__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar1,param2_00,
		               Method_Gameplay_Antiq_Model_EffectData___c__DisplayClass5_0__GetValue_b__0__,0);
		    uVar1 = func_ii_7423(param1_00,uVar1,
		                         Method_System_Linq_Enumerable_First_Antiq_Types_EffectsDic_Types_EffectStringValueDic___
		                        );
		    uVar1 = Core_Extensions_Dict_Antiq_CategoryDicExt__GetTitle(uVar1,0);
		  }
		  return uVar1;
		}
		*/

			return 0U;
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054F3")]
		[Address(RVA = "0xA299", Offset = "0xA299", VA = "0xA299")]
		public string GetValue()
		{
		/* --- GHIDRA: GetValue ---
		uint Gameplay_Antiq_Model_EffectData__GetValue(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  if (DAT_ram_00a594a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_uint___);
		    DAT_ram_00a594a7 = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__First_long_
		                    (*(undefined4 *)(param2 + 0x10),Method_System_Linq_Enumerable_First_uint___);
		  return (uint)(*(ulonglong *)(*(int *)(param1 + 0xc) + 0x10) == (ulonglong)uVar1);
		}
		*/

			return null;
		}

		// Token: 0x04002E08 RID: 11784
		[Token(Token = "0x4002E08")]
		[FieldOffset(Offset = "0x8")]
		private readonly ReadOnlyCollection<Antiq.Types.EffectsDic.Types.EffectStringValueDic> _effectValueStrings;

		// Token: 0x04002E09 RID: 11785
		[Token(Token = "0x4002E09")]
		[FieldOffset(Offset = "0xC")]
		public readonly Antiq.Types.EffectsDic EffectsDic;

		// Token: 0x04002E0A RID: 11786
		[Token(Token = "0x4002E0A")]
		[FieldOffset(Offset = "0x10")]
		public readonly ArtifactData Artifact;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TimeLeft ---
		void Core_Data_Effect_EffectData__get_TimeLeft(int param1,undefined4 param2,undefined4 param3)
		
		{
		  float fVar1;
		  int iVar2;
		  
		  *(undefined4 *)(param1 + 0x28) = param2;
		  fVar1 = UnityEngine_SystemClock___cctor(0);
		  if (ABS(fVar1) < 2.1474836e+09) {
		    iVar2 = (int)fVar1;
		  }
		  else {
		    iVar2 = -0x80000000;
		  }
		  *(ulonglong *)(param1 + 0x20) = (ulonglong)*(uint *)(param1 + 0x28) + (longlong)iVar2;
		  return;
		}
		*/


		/* --- GHIDRA: get_Duration ---
		longlong Core_Data_Effect_EffectData__get_Duration(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  longlong lVar2;
		  int iVar3;
		  
		  lVar2 = *(longlong *)(param1 + 0x20);
		  fVar1 = UnityEngine_SystemClock___cctor(0);
		  if (ABS(fVar1) < 2.1474836e+09) {
		    iVar3 = (int)fVar1;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  lVar2 = lVar2 - iVar3;
		  if (lVar2 < 1) {
		    lVar2 = 0;
		  }
		  return lVar2;
		}
		*/


		/* --- GHIDRA: get_CurrentDuration ---
		undefined8 Core_Data_Effect_EffectData__get_CurrentDuration(int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  
		  if (DAT_ram_00a60842 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    DAT_ram_00a60842 = '\x01';
		  }
		  uVar1 = func_ii_7271(*(undefined4 *)(*(int *)(param1 + 0xc) + 0x14),2,
		                       Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_MaxStack ---
		int Core_Data_Effect_EffectData__get_MaxStack(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a60843 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Effect_CombatLongEffectDescription_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Effect_EffectData___TypeInfo);
		    DAT_ram_00a60843 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x30);
		  if (iVar3 == 0) {
		    uVar1 = Core_Extensions_Dict_EffectDictExt__GetTitle(*(undefined4 *)(param1 + 8),0);
		    piVar2 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_Effect_EffectData___TypeInfo,1);
		    iVar3 = func_ii_1082(param1,*(undefined4 *)(*piVar2 + 0x20));
		    if (iVar3 == 0) {
		      uVar1 = func_ii_1083();
		      func_ii_1050(uVar1,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar2[4] = param1;
		    iVar3 = unnamed_function_1417(Core_Data_Effect_CombatLongEffectDescription_TypeInfo);
		    *(undefined4 *)(iVar3 + 0x14) = 0;
		    *(int **)(iVar3 + 0x10) = piVar2;
		    *(undefined4 *)(iVar3 + 0xc) = uVar1;
		    *(int *)(param1 + 0x30) = iVar3;
		  }
		  return iVar3;
		}
		*/

}
