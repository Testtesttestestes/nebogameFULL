using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D8D RID: 3469
	[Token(Token = "0x2000D8D")]
	internal class ArtifactData
	{
		// Token: 0x060054E5 RID: 21733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E5")]
		[Address(RVA = "0x1D19", Offset = "0x1D19", VA = "0x1D19")]
		public ArtifactData(int index, Antiq.Types.ArtifactsDic artifactDic)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Antiq_Model_ArtifactData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a594a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RewardInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_RewardInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Model_ArtifactData___c__GetEffectsRewards_b__5_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Model_ArtifactData___c_TypeInfo);
		    DAT_ram_00a594a2 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x28);
		  if (*(int *)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_RewardInfo__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_Antiq_Model_ArtifactData___c__GetEffectsRewards_b__5_0__,0);
		    *(int *)(*(int *)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Where_RewardInfo___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054E6")]
		[Address(RVA = "0x1D1A", Offset = "0x1D1A", VA = "0x1D1A")]
		public RewardInfo[] GetEffectsRewards()
		{
		/* --- GHIDRA: GetEffectsRewards ---
		void Gameplay_Antiq_Model_ArtifactData__GetEffectsRewards
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a594a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_EffectData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData__Sort__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Antiq_Model_ArtifactData___c__AddEffects_b__6_0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Model_ArtifactData___c_TypeInfo);
		    DAT_ram_00a594a3 = '\x01';
		  }
		  func_ii_6335(*(undefined4 *)(param1 + 8),param2,
		               Method_System_Collections_Generic_List_EffectData__AddRange__);
		  param1_00 = *(undefined4 *)(param1 + 8);
		  if (*(int *)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x5c);
		  param1_01 = puVar1[2];
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    param1_01 = unnamed_function_1417(System_Comparison_EffectData__TypeInfo);
		    System_Collections_Generic_Comparer_object___get_Default
		              (param1_01,param2_00,Method_Gameplay_Antiq_Model_ArtifactData___c__AddEffects_b__6_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Antiq_Model_ArtifactData___c_TypeInfo + 0x5c) + 8) = param1_01;
		  }
		  Google_Protobuf_Collections_RepeatedField_uint___Contains
		            (param1_00,param1_01,Method_System_Collections_Generic_List_EffectData__Sort__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E7")]
		[Address(RVA = "0x1D1B", Offset = "0x1D1B", VA = "0x1D1B")]
		public void AddEffects(IEnumerable<EffectData> value)
		{
		}

		// Token: 0x04002DFF RID: 11775
		[Token(Token = "0x4002DFF")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<EffectData> _effects;

		// Token: 0x04002E00 RID: 11776
		[Token(Token = "0x4002E00")]
		[FieldOffset(Offset = "0xC")]
		public readonly Antiq.Types.ArtifactsDic ArtifactDic;

		// Token: 0x04002E01 RID: 11777
		[Token(Token = "0x4002E01")]
		[FieldOffset(Offset = "0x10")]
		public readonly ReadOnlyCollection<EffectData> Effects;

		// Token: 0x04002E02 RID: 11778
		[Token(Token = "0x4002E02")]
		[FieldOffset(Offset = "0x14")]
		public readonly int Index;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_IsFavoriteChangedEvent ---
		void Core_Data_ArtifactData__add_IsFavoriteChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6077b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6077b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x38,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_IsFavoriteChangedEvent ---
		void Core_Data_ArtifactData__remove_IsFavoriteChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6077c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6077c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x3c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_IsFreshChangedEvent ---
		void Core_Data_ArtifactData__add_IsFreshChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6077d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6077d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x3c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_IsFreshChangedEvent ---
		void Core_Data_ArtifactData__remove_IsFreshChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6077e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6077e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x40,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_IsFreshWatchedChangedEvent ---
		void Core_Data_ArtifactData__add_IsFreshWatchedChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6077f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6077f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x40,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_IsFreshWatchedChangedEvent ---
		void Core_Data_ArtifactData__remove_IsFreshWatchedChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60780 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60780 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x44,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ArtifactInfoChangedEvent ---
		void Core_Data_ArtifactData__add_ArtifactInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60781 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60781 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x44,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ArtifactInfoChangedEvent ---
		void Core_Data_ArtifactData__remove_ArtifactInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60782 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60782 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x48,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_IsMostPowerfulChangedEvent ---
		void Core_Data_ArtifactData__add_IsMostPowerfulChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60783 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60783 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x48,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_IsMostPowerfulChangedEvent ---
		void Core_Data_ArtifactData__remove_IsMostPowerfulChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60784 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60784 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x4c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_SlotIdChangedEvent ---
		void Core_Data_ArtifactData__add_SlotIdChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60785 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60785 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x4c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_IsMostPowerful ---
		int * Core_Data_ArtifactData__set_IsMostPowerful(int *param1)
		
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


		/* --- GHIDRA: get_IsFavorite ---
		void Core_Data_ArtifactData__get_IsFavorite(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(byte *)(param1 + 0x78) != param2) {
		    *(char *)(param1 + 0x78) = (char)param2;
		    iVar1 = *(int *)(param1 + 0x38);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_IsFresh ---
		void Core_Data_ArtifactData__get_IsFresh(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(byte *)(param1 + 0x79) != param2) {
		    *(char *)(param1 + 0x79) = (char)param2;
		    iVar1 = *(int *)(param1 + 0x3c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsFresh ---
		uint Core_Data_ArtifactData__set_IsFresh(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(param1 + 0x7a);
		}
		*/


		/* --- GHIDRA: get_IsFreshWatched ---
		void Core_Data_ArtifactData__get_IsFreshWatched(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(byte *)(param1 + 0x7a) != param2) {
		    *(char *)(param1 + 0x7a) = (char)param2;
		    iVar1 = *(int *)(param1 + 0x40);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_ArtifactInfo ---
		void Core_Data_ArtifactData__get_ArtifactInfo
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  double dVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a60786 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a60786 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x74) == 0) ||
		     (iVar2 = Protocol_Common_ArtifactInfo__Equals(*(int *)(param1 + 0x74),param2,0), iVar2 == 0)) {
		    *(undefined4 *)(param1 + 0x74) = param2;
		    Core_Data_ArtifactData__get_CommonModifierData(param1,param3,param1);
		    Core_Data_ArtifactData__UpdateModifiers(param1,param3,param1);
		    if (*(int *)(param1 + 0x74) != 0) {
		      param1_00 = *(undefined4 *)(param1 + 0x88);
		      dVar1 = func_ii_7527(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x74) + 0x20) + 0xc),5,
		                           Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		      Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,(float)dVar1,0);
		    }
		    iVar2 = *(int *)(param1 + 0x44);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: SetArtifactInfo ---
		int Core_Data_ArtifactData__SetArtifactInfo(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x84);
		  if (iVar1 == 0) {
		    if (DAT_ram_00a60792 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__
		                );
		      DAT_ram_00a60792 = '\x01';
		    }
		    param1_00 = Core_Extensions_Dict_DictExt__GetArtikul
		                          (*(undefined4 *)(*(int *)(param1 + 8) + 0x10),0);
		    iVar1 = func_ii_7775(param1_00,0);
		    *(int *)(param1 + 0x84) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_ArtifactId ---
		int * Core_Data_ArtifactData__get_ArtifactId(int *param1)
		
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


		/* --- GHIDRA: get_TitleToLower ---
		undefined4 Core_Data_ArtifactData__get_TitleToLower(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60788 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a60788 = '\x01';
		  }
		  if (*(int *)(param1 + 0x74) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    dVar1 = func_ii_7527(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x74) + 0x20) + 0xc),1,
		                         Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    if (ABS(dVar1) < 2147483648.0) {
		      return (int)dVar1;
		    }
		    uVar2 = 0x80000000;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_CurrentDurability ---
		undefined4 Core_Data_ArtifactData__get_CurrentDurability(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60788 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a60788 = '\x01';
		  }
		  if (*(int *)(param1 + 0x74) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    dVar1 = func_ii_7527(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x74) + 0x20) + 0xc),0,
		                         Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    if (ABS(dVar1) < 2147483648.0) {
		      return (int)dVar1;
		    }
		    uVar2 = 0x80000000;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_MaxDurability ---
		undefined4 Core_Data_ArtifactData__get_MaxDurability(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60788 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a60788 = '\x01';
		  }
		  if (*(int *)(param1 + 0x74) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    dVar1 = func_ii_7527(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x74) + 0x20) + 0xc),7,
		                         Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    if (ABS(dVar1) < 2147483648.0) {
		      return (int)dVar1;
		    }
		    uVar2 = 0x80000000;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_StackLimit ---
		undefined4 Core_Data_ArtifactData__get_StackLimit(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60788 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a60788 = '\x01';
		  }
		  if (*(int *)(param1 + 0x74) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    dVar1 = func_ii_7527(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x74) + 0x20) + 0xc),2,
		                         Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    if (ABS(dVar1) < 2147483648.0) {
		      return (int)dVar1;
		    }
		    uVar2 = 0x80000000;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_MinLevel ---
		undefined4 Core_Data_ArtifactData__get_MinLevel(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60792 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a60792 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0x34);
		}
		*/


		/* --- GHIDRA: get_Cult ---
		undefined4 Core_Data_ArtifactData__get_Cult(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60792 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a60792 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0x38);
		}
		*/


		/* --- GHIDRA: get_Rank ---
		uint Core_Data_ArtifactData__get_Rank(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  double dVar3;
		  
		  uVar1 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xfc));
		  if (iVar2 < 1) {
		    if (DAT_ram_00a60788 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		      DAT_ram_00a60788 = '\x01';
		    }
		    uVar1 = 0;
		    if (param1[0x1d] != 0) {
		      dVar3 = func_ii_7527(*(undefined4 *)(*(int *)(param1[0x1d] + 0x20) + 0xc),9,
		                           Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		      if (ABS(dVar3) < 2147483648.0) {
		        iVar2 = (int)dVar3;
		      }
		      else {
		        iVar2 = -0x80000000;
		      }
		      uVar1 = (uint)(0 < iVar2);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsRestorable ---
		uint Core_Data_ArtifactData__get_IsRestorable(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  double dVar3;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a60792 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a60792 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1[2] + 0x10) + 0x30) != '\0') {
		    uVar1 = 1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xfc));
		    if (iVar2 < 1) {
		      if (DAT_ram_00a60788 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		        DAT_ram_00a60788 = '\x01';
		      }
		      uVar1 = 1;
		      if (param1[0x1d] != 0) {
		        dVar3 = func_ii_7527(*(undefined4 *)(*(int *)(param1[0x1d] + 0x20) + 0xc),9,
		                             Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		        if (ABS(dVar3) < 2147483648.0) {
		          iVar2 = (int)dVar3;
		        }
		        else {
		          iVar2 = -0x80000000;
		        }
		        uVar1 = (uint)(iVar2 < 1);
		      }
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsForgeable ---
		uint Core_Data_ArtifactData__get_IsForgeable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  float fVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a60787 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a60787 = '\x01';
		  }
		  iVar1 = Core_Data_ArtikulData__get_MinDurability(param1,param1);
		  if (iVar1 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    fVar2 = func_ii_7103(*(undefined4 *)(param1 + 0x88),0);
		    iVar1 = *(int *)(param1 + 0x34);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar3 = func_ii_7331((longlong)iVar1,0);
		    uVar4 = (uint)(fVar2 < fVar3);
		  }
		  return uVar4;
		}
		*/


		/* --- GHIDRA: get_IsTemporaryWithCriticalLifetime ---
		uint Core_Data_ArtifactData__get_IsTemporaryWithCriticalLifetime(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  uint uVar3;
		  
		  iVar1 = Core_Data_ArtikulData__get_MinDurability(param1,param1);
		  if (iVar1 == 0) {
		    uVar3 = 0;
		  }
		  else {
		    fVar2 = func_ii_7103(*(undefined4 *)(param1 + 0x88),0);
		    uVar3 = (uint)(fVar2 <= 0.0);
		  }
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_IsTemporaryWithExpiredLifetime ---
		undefined4 Core_Data_ArtifactData__get_IsTemporaryWithExpiredLifetime(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Utils_MoneyUtils__ExtractArtifactCostMoney
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x74) + 0x20) + 0xc),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Price ---
		void Core_Data_ArtifactData__get_Price(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 0x74) + 0x24) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_SellPrice ---
		undefined4 Core_Data_ArtifactData__get_SellPrice(int param1,double param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a605f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4598);
		    DAT_ram_00a605f8 = '\x01';
		  }
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  if (param1 != **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c)) {
		    if (param2 < 0.0) {
		      uVar1 = func_ii_4419(StringLiteral_4598,param1,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7109(uVar1,0);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      if (DAT_ram_00a605fb == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		        Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		        DAT_ram_00a605fb = '\x01';
		      }
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      uVar2 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		      uVar1 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		      Core_Money_Money__op_Equality(uVar1,uVar2,0.0,0,uVar2);
		      return uVar1;
		    }
		    uVar1 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		    Core_Money_Money__op_Equality(uVar1,param1,param2,0,param1);
		    return uVar1;
		  }
		  uVar1 = unnamed_function_2232(&Core_Money_MoneyException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_4597);
		  func_ii_13902(uVar1,uVar2,uVar1);
		  uVar2 = unnamed_function_2232(&Method_Core_Money_Money_FromResource__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_SellPrice ---
		undefined4 Core_Data_ArtifactData__set_SellPrice(int param1,undefined4 param2,undefined4 param3)
		
		{
		  double dVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60788 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a60788 = '\x01';
		  }
		  if (*(int *)(param1 + 0x74) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    dVar1 = func_ii_7527(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x74) + 0x20) + 0xc),param2,
		                         Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    if (ABS(dVar1) < 2147483648.0) {
		      return (int)dVar1;
		    }
		    uVar2 = 0x80000000;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: GetArtSkillValue ---
		void Core_Data_ArtifactData__GetArtSkillValue(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60789 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ModifierData__TypeInfo);
		    DAT_ram_00a60789 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,0.0,0);
		  *(undefined4 *)(param1 + 0x88) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ModifierData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ModifierData___ctor__);
		  *(undefined4 *)(param1 + 0x8c) = uVar1;
		  Core_Data_ArtikulData__set_TempItemCriticalTtl(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: get_ModifierData ---
		int Core_Data_ArtifactData__get_ModifierData(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param2_00;
		  uint param2_01;
		  uint uVar3;
		  uint param2_02;
		  
		  if (DAT_ram_00a6078a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ModifierData__TypeInfo);
		    DAT_ram_00a6078a = '\x01';
		  }
		  param2_01 = *(uint *)(*(int *)(param1 + 0x8c) + 0xc);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ModifierData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,param2_01,Method_System_Collections_Generic_List_ModifierData___ctor__);
		  if (0 < (int)param2_01) {
		    do {
		      param2_02 = param2_01 - 1;
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x8c),param2_02,
		                         Method_System_Collections_Generic_List_ModifierData__get_Item__);
		      if (*(int *)(*(int *)(iVar2 + 8) + 0x14) != 0) {
		        param2_00 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x8c),param2_02,
		                               Method_System_Collections_Generic_List_ModifierData__get_Item__);
		        iVar2 = Method_System_Collections_Generic_List_ModifierData__Add__;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar3 = *(uint *)(param1_00 + 0xc);
		        if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      bVar1 = 1 < param2_01;
		      param2_01 = param2_02;
		    } while (bVar1);
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: get_SpellsModifierData ---
		int Core_Data_ArtifactData__get_SpellsModifierData(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param2_00;
		  uint param2_01;
		  uint uVar3;
		  uint param2_02;
		  
		  if (DAT_ram_00a6078b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ModifierData__TypeInfo);
		    DAT_ram_00a6078b = '\x01';
		  }
		  param2_01 = *(uint *)(*(int *)(param1 + 0x8c) + 0xc);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ModifierData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,param2_01,Method_System_Collections_Generic_List_ModifierData___ctor__);
		  if (0 < (int)param2_01) {
		    do {
		      param2_02 = param2_01 - 1;
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x8c),param2_02,
		                         Method_System_Collections_Generic_List_ModifierData__get_Item__);
		      if (*(int *)(*(int *)(iVar2 + 8) + 0x14) == 0) {
		        param2_00 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x8c),param2_02,
		                               Method_System_Collections_Generic_List_ModifierData__get_Item__);
		        iVar2 = Method_System_Collections_Generic_List_ModifierData__Add__;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar3 = *(uint *)(param1_00 + 0xc);
		        if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      bVar1 = 1 < param2_01;
		      param2_01 = param2_02;
		    } while (bVar1);
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: get_CommonModifierData ---
		void Core_Data_ArtifactData__get_CommonModifierData(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int param1_00;
		  uint uVar6;
		  int param2_00;
		  int iVar7;
		  int *piVar8;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a6078c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ModifierData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_ModifierData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Common_SpellModifierInfo_TypeInfo);
		    DAT_ram_00a6078c = '\x01';
		  }
		  if (*(int *)(param1 + 0x74) != 0) {
		    iVar1 = unnamed_function_1417(System_Collections_Generic_List_ModifierData__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (iVar1,Method_System_Collections_Generic_List_ModifierData___ctor__);
		    *(int *)(param1 + 0x8c) = iVar1;
		    iVar5 = *(int *)(*(int *)(*(int *)(param1 + 0x74) + 0x1c) + 0xc);
		    if (0 < iVar5) {
		      do {
		        iVar1 = unnamed_function_1417(Protocol_Common_SpellModifierInfo_TypeInfo);
		        uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(*(int *)(param1 + 0x74) + 0x1c),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		        *(undefined4 *)(iVar1 + 0xc) = uVar4;
		        *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(*(int *)(param1 + 0x74) + 0x18);
		        param1_00 = *(int *)(param1 + 0x8c);
		        iVar7 = *param2;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar6 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar6 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar8) {
		              puVar2 = (uint *)(piVar8[1] * 8 + iVar7 + 0xd0);
		              goto code_r0x81cde0b6;
		            }
		            uVar6 = uVar6 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar6);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81cde0b6:
		        uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(*(int *)(param1 + 0x74) + 0x1c),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		        uVar4 = Core_Dict_Controller_BaseDictController__LoadDict(uVar4,uVar3,0);
		        uVar3 = unnamed_function_1417(Core_Data_ModifierData_TypeInfo);
		        Core_Data_ModifierData__set_ModifierInfo(uVar3,uVar4,iVar1,uVar4);
		        iVar1 = Method_System_Collections_Generic_List_ModifierData__Add__;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar6 = *(uint *)(param1_00 + 0xc);
		        if (uVar6 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar6 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar6 * 4 + 0x10) = uVar3;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		        param2_00 = param2_00 + 1;
		      } while (param2_00 != iVar5);
		      iVar1 = *(int *)(param1 + 0x8c);
		    }
		    if (0 < *(int *)(iVar1 + 0xc)) {
		      uVar4 = func_ii_14058(iVar1,iVar1);
		      *(undefined4 *)(param1 + 0x8c) = uVar4;
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: UpdateModifiers ---
		void Core_Data_ArtifactData__UpdateModifiers(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a6078d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillCollection_TypeInfo);
		    DAT_ram_00a6078d = '\x01';
		  }
		  if (*(int *)(param1 + 0x74) == 0) {
		    return;
		  }
		  uVar7 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x74) + 0x20) + 0x10);
		  uVar2 = unnamed_function_1417(Core_Data_Skills_SkillCollection_TypeInfo);
		  Core_Extensions_Dict_DictExt__GetModifier(uVar2,uVar7,uVar7);
		  *(undefined4 *)(param1 + 0x50) = uVar2;
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param1 + 0x74) + 0x1c),
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x81cde24b:
		  piVar5 = local_4;
		  iVar8 = *local_4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		        puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		        goto code_r0x81cde2e3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x81cde32b:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81cde673;
		  }
		code_r0x81cde2e3:
		  DAT_ram_009d3e38 = 0;
		  iVar8 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		  piVar5 = local_4;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x81cde32b;
		  if (iVar8 == 0) {
		    iVar8 = 0;
		    goto code_r0x81cde6bc;
		  }
		  iVar8 = *local_4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		      if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		        puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		        goto code_r0x81cde3d0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x81cde62f:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81cde673;
		  }
		code_r0x81cde3d0:
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x81cde62f;
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		      if (Core_Dict_IDictProvider_TypeInfo == *piVar5) {
		        puVar3 = (undefined4 *)(piVar5[1] * 8 + iVar8 + 0xd0);
		        goto code_r0x81cde4a1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2,
		                      Core_Dict_IDictProvider_TypeInfo,2);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x81cde639:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81cde673;
		  }
		code_r0x81cde4a1:
		  DAT_ram_009d3e38 = 0;
		  uVar7 = import::env::invoke_iii(*puVar3,param2,puVar3[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x81cde639;
		  DAT_ram_009d3e38 = 0;
		  iVar4 = import::env::invoke_iiii
		                    (s___Scripting__UnityEngine__Render_ram_000036af + 0x2e,uVar7,uVar2,0);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81cde673;
		  }
		  uVar7 = *(undefined4 *)(iVar4 + 0x18);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     Core_Data_Skills_SkillCollection_TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x81cde64d:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81cde673;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viii(s___Scripting__UnityEngine__Render_ram_000036af + 0x2f,uVar2,uVar7,uVar2)
		  ;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x81cde64d;
		  DAT_ram_009d3e38 = 0;
		  iVar4 = import::env::invoke_iii
		                    (s___Scripting__UnityEngine__Render_ram_000036af + 0x30,uVar2,uVar2);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 != 1) {
		    if (iVar4 != 0) {
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii
		                        (s___Scripting__UnityEngine__Render_ram_000036af + 0x31,uVar2,uVar2);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cde673;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x76,
		                         *(undefined4 *)(param1 + 0x50),uVar2,*(undefined4 *)(param1 + 0x50));
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cde673;
		      }
		      *(undefined4 *)(param1 + 0x50) = uVar2;
		    }
		    goto code_r0x81cde24b;
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cde673:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar8 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x81cde6bc:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81cde734;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81cde734:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x32,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: UpdateUserSkills ---
		undefined4 Core_Data_ArtifactData__UpdateUserSkills(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  ushort local_2;
		  
		  if (DAT_ram_00a6078e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__get_Value__);
		    DAT_ram_00a6078e = '\x01';
		  }
		  if (*(char *)(param1 + 0x90) == '\0') {
		    iVar2 = Mono_Security_ASN1Convert__ToOid(long___TypeInfo,2);
		    if (DAT_ram_00a60792 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__
		                );
		      DAT_ram_00a60792 = '\x01';
		    }
		    *(ulonglong *)(iVar2 + 0x10) = (ulonglong)*(uint *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0xc)
		    ;
		    *(ulonglong *)(iVar2 + 0x18) = (ulonglong)*(uint *)(*(int *)(param1 + 0xc) + 0xc);
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		          goto code_r0x81ce061d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,5)
		    ;
		code_r0x81ce061d:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar2,puVar3[1]);
		    local_2 = 0;
		    System_Data_SqlTypes_SqlByte__ToSqlInt64(&local_2,uVar4,Method_System_Nullable_bool___ctor__);
		    *(ushort *)(param1 + 0x90) = local_2;
		  }
		  uVar4 = UnityEngine_UI_RawImage__set_texture
		                    ((ushort *)(param1 + 0x90),Method_System_Nullable_bool__get_Value__);
		  return uVar4;
		}
		*/


		/* --- GHIDRA: IsGuideTarget ---
		int Core_Data_ArtifactData__IsGuideTarget
		              (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *param4_00;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a6078f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a6078f = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Data_ArtifactData_TypeInfo);
		  Core_Data_ArtifactData__GetArtSkillValue(param1_00,param2);
		  *(undefined4 *)(param1_00 + 0x6c) = param2;
		  iVar2 = *param3;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param4_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x81ce0729;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param4_00 = (uint *)func_ii_1080(param3,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x81ce0729:
		  iVar2 = (**(code **)((ulonglong)*param4_00 * 4))(param3,param4_00[1]);
		  param2_00 = func_ii_7730(*(undefined4 *)(iVar2 + 8),*(undefined4 *)(param1 + 0x18),
		                           Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint__GetWrapper__
		                          );
		  Core_Data_ArtikulData__get_MiddleBgSubstrateAssetId(param1_00,param2_00,param3,param4_00);
		  Core_Data_ArtifactData__get_ArtifactInfo(param1_00,param1,param3,param4_00);
		  return param1_00;
		}
		*/


		/* --- GHIDRA: Create ---
		undefined4 Core_Data_ArtifactData__Create(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60790 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData_TypeInfo);
		    DAT_ram_00a60790 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Data_ArtifactData_TypeInfo);
		  Core_Data_ArtifactData__GetArtSkillValue(param1_00,param1_00);
		  return param1_00;
		}
		*/


		/* --- GHIDRA: CreateEmpty ---
		undefined4 Core_Data_ArtifactData__CreateEmpty(int param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60791 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventorySlotType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3291);
		    DAT_ram_00a60791 = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if (*(int *)(param1 + 0x74) == 0) {
		    local_8 = 0;
		  }
		  else {
		    local_8 = *(undefined8 *)(*(int *)(param1 + 0x74) + 0x10);
		  }
		  iVar1 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = iVar1;
		  if (DAT_ram_00a60792 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a60792 = '\x01';
		  }
		  iVar1 = Core_Extensions_Dict_DictExt__GetArtikul(*(undefined4 *)(*(int *)(param1 + 8) + 0x10),0);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar1;
		  local_c = *(undefined4 *)(param1 + 0x7c);
		  iVar1 = func_ii_1081(DAT_ram_00a66954,&local_c);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = iVar1;
		  local_10 = *(undefined4 *)(param1 + 0x80);
		  iVar1 = func_ii_1081(Gameplay_Inventory_Model_InventorySlotType_TypeInfo,&local_10);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_3291,param2_00,0);
		  return uVar3;
		}
		*/

}
