using System;
using System.Collections.Generic;
using Core.Data.User;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000961 RID: 2401
	[Token(Token = "0x2000961")]
	[Serializable]
	public class CombatAnimationsMode
	{
		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B37")]
		public Transform Parent
		{
			[Token(Token = "0x60038FB")]
			[Address(RVA = "0x8898", Offset = "0x8898", VA = "0x8898")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FC")]
		[Address(RVA = "0x8899", Offset = "0x8899", VA = "0x8899")]
		public void Init(UserSettings settings)
		{
		/* --- GHIDRA: Init ---
		undefined4
		Gameplay_Combat_View_GameField_CombatAnimationsMode__Init
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5672c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_ReleaseCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Cache_GameObjectPoolRestricted_StoneParticles___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Cache_GameObjectPoolRestricted_StoneParticlesOld___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPoolRestricted_StoneParticlesOld__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPoolRestricted_StoneParticles__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_StoneParticles__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_StoneParticlesOld__TypeInfo);
		    DAT_ram_00a5672c = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 10) != '\0') {
		    uVar3 = *(undefined4 *)(param1 + 0xc);
		    uVar1 = unnamed_function_1417
		                      (Utils_Cache_ObjectPool_ResetPoolObjectDelegate_StoneParticles__TypeInfo);
		    Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		              (uVar1,param1,
		               Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_ReleaseCallback__,0);
		    uVar2 = unnamed_function_1417(Utils_Cache_GameObjectPoolRestricted_StoneParticles__TypeInfo);
		    UnityEngine_UIElements_UIR_Utility_GPUBuffer___Il2CppFullySharedGenericStructType___get_ElementStride
		              (uVar2,uVar3,param2,uVar1,
		               Method_Utils_Cache_GameObjectPoolRestricted_StoneParticles___ctor__);
		    return uVar2;
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417
		                    (Utils_Cache_ObjectPool_ResetPoolObjectDelegate_StoneParticlesOld__TypeInfo);
		  Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (uVar1,param1,
		             Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_ReleaseCallback__,0);
		  uVar2 = unnamed_function_1417(Utils_Cache_GameObjectPoolRestricted_StoneParticlesOld__TypeInfo);
		  UnityEngine_UIElements_UIR_Utility_GPUBuffer___Il2CppFullySharedGenericStructType___get_ElementStride
		            (uVar2,uVar3,param2,uVar1,
		             Method_Utils_Cache_GameObjectPoolRestricted_StoneParticlesOld___ctor__);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038FD")]
		[Address(RVA = "0x889A", Offset = "0x889A", VA = "0x889A")]
		public IPool<IStoneParticles> CreateParticlesPool(Transform parent)
		{
		/* --- GHIDRA: CreateParticlesPool ---
		undefined4
		Gameplay_Combat_View_GameField_CombatAnimationsMode__CreateParticlesPool
		          (int param1,undefined4 param2)
		
		{
		  char cVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  
		  if (DAT_ram_00a5672d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_HandleImpactEmpty__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_HandleImpact__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_GameFieldMono_ImpactDelegate_TypeInfo);
		    DAT_ram_00a5672d = '\x01';
		  }
		  cVar1 = *(char *)(*(int *)(param1 + 8) + 10);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_GameField_GameFieldMono_ImpactDelegate_TypeInfo);
		  puVar2 = &Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_HandleImpact__;
		  if (cVar1 == '\0') {
		    puVar2 = &Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_HandleImpactEmpty__;
		  }
		  Gameplay_Combat_View_GameField_GameFieldMono___ctor(param1_00,param1,*puVar2,param1);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038FE")]
		[Address(RVA = "0x889B", Offset = "0x889B", VA = "0x889B")]
		public GameFieldMono.ImpactDelegate GetImpactFunction()
		{
		/* --- GHIDRA: GetImpactFunction ---
		void Gameplay_Combat_View_GameField_CombatAnimationsMode__GetImpactFunction
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int param4_00;
		  int iVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5672e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_StoneMono__Vector2___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_Vector2___);
		    Mono_Security_ASN1__get_Item(&System_Func_StoneMono__Vector2__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_GameField_CombatAnimationsMode___c__HandleImpact_b__9_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo);
		    DAT_ram_00a5672e = '\x01';
		  }
		  if (*(int *)(Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo + 0x5c)
		  ;
		  iVar6 = puVar5[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo);
		      puVar5 = *(undefined4 **)
		                (Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar5;
		    iVar6 = unnamed_function_1417(System_Func_StoneMono__Vector2__TypeInfo);
		    System_Func_object__ulong___Invoke
		              (iVar6,uVar1,
		               Method_Gameplay_Combat_View_GameField_CombatAnimationsMode___c__HandleImpact_b__9_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo + 0x5c) + 4)
		         = iVar6;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (param2,iVar6,Method_System_Linq_Enumerable_Select_StoneMono__Vector2___);
		  uVar1 = System_Linq_Enumerable__ToArray_ulong_
		                    (uVar1,Method_System_Linq_Enumerable_ToArray_Vector2___);
		  iVar2 = System_Array__CreateInstanceImpl(param3,0,0);
		  iVar3 = System_Array__CreateInstanceImpl(param3,1,0);
		  for (iVar6 = System_Array__GetRank(param3,0,0); iVar6 <= iVar2; iVar6 = iVar6 + 1) {
		    for (param4_00 = System_Array__GetRank(param3,1,0); param4_00 <= iVar3;
		        param4_00 = param4_00 + 1) {
		      param1_00 = *(undefined4 *)
		                   (param3 + (*(int *)(*(int *)(param3 + 8) + 8) * iVar6 + param4_00) * 4 + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar4 = func_ii_3812(param1_00,0,0);
		      if (iVar4 == 0) {
		        Gameplay_Combat_View_GameField_StoneMono__Impact(param1_00,uVar1,0.0,param4_00);
		      }
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FF")]
		[Address(RVA = "0x889C", Offset = "0x889C", VA = "0x889C")]
		private void HandleImpact(IEnumerable<StoneMono> stones, StoneMono[,] allStones)
		{
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003900")]
		[Address(RVA = "0x889D", Offset = "0x889D", VA = "0x889D")]
		private void HandleImpactEmpty(IEnumerable<StoneMono> stones, StoneMono[,] allStones)
		{
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003901")]
		[Address(RVA = "0x889E", Offset = "0x889E", VA = "0x889E")]
		private void ReleaseCallback(Component component)
		{
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003902")]
		[Address(RVA = "0x889F", Offset = "0x889F", VA = "0x889F")]
		public CombatAnimationsMode()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_GameField_CombatAnimationsMode___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5672f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo);
		    DAT_ram_00a5672f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Combat_View_GameField_CombatAnimationsMode___c_TypeInfo + 0x5c) = uVar1
		  ;
		  return;
		}
		*/

		}

		// Token: 0x04001F7E RID: 8062
		[Token(Token = "0x4001F7E")]
		[FieldOffset(Offset = "0x8")]
		private UserSettings _settings;

		// Token: 0x04001F7F RID: 8063
		[Token(Token = "0x4001F7F")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private StoneParticles _animatedParticles;

		// Token: 0x04001F80 RID: 8064
		[Token(Token = "0x4001F80")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StoneParticlesOld _oldParticles;

		// Token: 0x04001F81 RID: 8065
		[Token(Token = "0x4001F81")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _parent;
	}
}
