using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements;
using Core.Gameplay.Managers.Ad.Providers;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Services;

namespace Core.Gameplay.Managers.Ad.Model
{
	// Token: 0x02001222 RID: 4642
	[Token(Token = "0x2001222")]
	public abstract class AbstractAdModel : AbstractModel, IOptionValidator, IAdPlacementManagerProvider
	{
		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06006DE2 RID: 28130
		[Token(Token = "0x1700164C")]
		public abstract uint[] SupportedAdProviders { [Token(Token = "0x6006DE2")] get; }

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06006DE3 RID: 28131 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700164D")]
		public virtual uint[] SupportedAdPlacements
		{
			[Token(Token = "0x6006DE3")]
			[Address(RVA = "0xB89B", Offset = "0xB89B", VA = "0xB89B", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06006DE4 RID: 28132 RVA: 0x00014268 File Offset: 0x00012468
		[Token(Token = "0x1700164E")]
		public bool IsFeatureAvailable
		{
			[Token(Token = "0x6006DE4")]
			[Address(RVA = "0xB89C", Offset = "0xB89C", VA = "0xB89C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06006DE5 RID: 28133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700164F")]
		public Dictionary<uint, IAdPlacementData> Placements
		{
			[Token(Token = "0x6006DE5")]
			[Address(RVA = "0xB89D", Offset = "0xB89D", VA = "0xB89D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06006DE6 RID: 28134 RVA: 0x00014280 File Offset: 0x00012480
		[Token(Token = "0x17001650")]
		public uint DefaultAdProviderId
		{
			[Token(Token = "0x6006DE6")]
			[Address(RVA = "0xB89E", Offset = "0xB89E", VA = "0xB89E")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DE7")]
		[Address(RVA = "0xB89F", Offset = "0xB89F", VA = "0xB89F")]
		public AbstractAdModel(IGame game, UserData user)
		{
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06006DE8 RID: 28136 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006DE9 RID: 28137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001651")]
		public AdTransaction CurrentTransaction
		{
			[Token(Token = "0x6006DE8")]
			[Address(RVA = "0xB8A0", Offset = "0xB8A0", VA = "0xB8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006DE9")]
			[Address(RVA = "0xB8A1", Offset = "0xB8A1", VA = "0xB8A1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DEA")]
		[Address(RVA = "0xB8A2", Offset = "0xB8A2", VA = "0xB8A2")]
		public void InitPlacements(IEnumerable<uint> placementIds, IAdController adController, AdEvents events)
		{
		/* --- GHIDRA: InitPlacements ---
		undefined4
		Core_Gameplay_Managers_Ad_Model_AbstractAdModel__InitPlacements
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__TryGetValue__);
		    DAT_ram_00a5a7b9 = '\x01';
		  }
		  uVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x10),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__TryGetValue__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DEB")]
		[Address(RVA = "0x2247", Offset = "0x2247", VA = "0x2247")]
		protected AbstractAdPlacementManager CreateAdPlacementManagers(IAdPlacementData placementData, IGame game, IAdController adController, AdEvents adEvents, UserData user)
		{
			return null;
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DEC")]
		[Address(RVA = "0x224E", Offset = "0x224E", VA = "0x224E")]
		public void UpdatePlacementInfo(AdPlacementInfo raw)
		{
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x00014298 File Offset: 0x00012498
		[Token(Token = "0x6006DED")]
		[Address(RVA = "0xB8A3", Offset = "0xB8A3", VA = "0xB8A3")]
		public bool TryGetAdPlacementData(uint adPlacement, out IAdPlacementData data)
		{
		/* --- GHIDRA: TryGetAdPlacementData ---
		undefined4
		Core_Gameplay_Managers_Ad_Model_AbstractAdModel__TryGetAdPlacementData
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__TryGetValue__
		              );
		    DAT_ram_00a5a7ba = '\x01';
		  }
		  uVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x14),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__TryGetValue__
		                    );
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x000142B0 File Offset: 0x000124B0
		[Token(Token = "0x6006DEE")]
		[Address(RVA = "0xB8A4", Offset = "0xB8A4", VA = "0xB8A4", Slot = "7")]
		public bool TryGetAdPlacementManager(uint adPlacement, out AbstractAdPlacementManager manager)
		{
		/* --- GHIDRA: TryGetAdPlacementManager ---
		undefined4
		Core_Gameplay_Managers_Ad_Model_AbstractAdModel__TryGetAdPlacementManager
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *local_4;
		  
		  local_4 = (int *)0x0;
		  iVar1 = System_Xml_Serialization_TypeTranslator__GetTypeData(param2,0);
		  if (iVar1 == 0) {
		    uVar2 = 1;
		  }
		  else {
		    uVar2 = *(undefined4 *)(param2 + 0x28);
		    if (DAT_ram_00a5a7ba == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__TryGetValue__
		                );
		      DAT_ram_00a5a7ba = '\x01';
		    }
		    iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                      (*(undefined4 *)(param1 + 0x14),uVar2,&local_4,
		                       Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__TryGetValue__
		                      );
		    if (iVar1 == 0) {
		      uVar2 = 0;
		    }
		    else {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*local_4 + 0xe8) * 4))
		                        (local_4,*(undefined4 *)(*local_4 + 0xec));
		    }
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x000142C8 File Offset: 0x000124C8
		[Token(Token = "0x6006DEF")]
		[Address(RVA = "0xB8A5", Offset = "0xB8A5", VA = "0xB8A5", Slot = "6")]
		private bool IsOptionValid(BankOptionData bankOptionData)
		{
			return default(bool);
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DF0")]
		[Address(RVA = "0xB8A6", Offset = "0xB8A6", VA = "0xB8A6", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0400397D RID: 14717
		[Token(Token = "0x400397D")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<uint, IAdPlacementData> _placements;

		// Token: 0x0400397E RID: 14718
		[Token(Token = "0x400397E")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<uint, AbstractAdPlacementManager> _placementManagers;

		// Token: 0x0400397F RID: 14719
		[Token(Token = "0x400397F")]
		[FieldOffset(Offset = "0x18")]
		public readonly IGame Game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SupportedAdPlacements ---
		uint Core_Gameplay_Managers_Ad_Model_AbstractAdModel__get_SupportedAdPlacements
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  return (uint)(*(int *)(iVar1 + 0xc) != 0);
		}
		*/


		/* --- GHIDRA: get_Placements ---
		undefined4
		Core_Gameplay_Managers_Ad_Model_AbstractAdModel__get_Placements(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		    DAT_ram_00a5a7b4 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = System_Linq_Enumerable__FirstOrDefault_int_
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_DefaultAdProviderId ---
		void Core_Gameplay_Managers_Ad_Model_AbstractAdModel__get_DefaultAdProviderId
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__IAdPlacementData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__2979CFBC0D27A1B6F791D2D5B84DD54825315753C7F10CF3C75FCD1AC35D863F
		              );
		    Mono_Security_ASN1__get_Item(&uint___TypeInfo);
		    DAT_ram_00a5a7b5 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid(uint___TypeInfo,0xb);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (uVar1,
		             Field__PrivateImplementationDetails__2979CFBC0D27A1B6F791D2D5B84DD54825315753C7F10CF3C75FCD1AC35D863F
		             ,0);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__IAdPlacementData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager___ctor__)
		  ;
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentTransaction ---
		void Core_Gameplay_Managers_Ad_Model_AbstractAdModel__set_CurrentTransaction
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a7b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_AdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__Clear__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a5a7b6 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__Clear__);
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8126e78b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_uint__TypeInfo,0);
		code_r0x8126e78b:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x8126e85d;
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
		code_r0x8126eada:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126eae2;
		    }
		code_r0x8126e85d:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8126eada;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x8126eb2b;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x8126e937;
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
		code_r0x8126eab2:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126eae2;
		    }
		code_r0x8126e937:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8126eab2;
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Core_Gameplay_Managers_Ad_Placements_AdPlacementData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8126eabc:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126eae2;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_0000223f + 7,iVar8,uVar4,iVar8);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8126eabc;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,
		               *(undefined4 *)(param1 + 0x10),uVar4,iVar8,
		               Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__Add__);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126eae2;
		    }
		    param3_00 = *(undefined4 *)(iVar8 + 8);
		    param2_00 = *(undefined4 *)(param1 + 0x14);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiiiiiii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 8,iVar8,iVar8,
		                       *(undefined4 *)(param1 + 0x18),param3,param4,*(undefined4 *)(param1 + 8),
		                       iVar8);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,param2_00,param3_00,uVar4,
		               Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__Add__)
		    ;
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8126eae2:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x8126eb2b:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8126eba3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8126eba3:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 9,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: Gameplay.Bank.Model.IOptionValidator.IsOptionValid ---
		void Core_Gameplay_Managers_Ad_Model_AbstractAdModel__Gameplay_Bank_Model_IOptionValidator_IsOptionValid
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a7bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AbstractAdPlacementManager__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AbstractAdPlacementManager__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AbstractAdPlacementManager__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AbstractAdPlacementManager__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IAdPlacementData__GetEnumerator__
		              );
		    DAT_ram_00a5a7bb = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_30,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IAdPlacementData__GetEnumerator__
		            );
		  local_8 = local_28;
		  local_30 = 0;
		  puStack_2c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126f6a1;
		    }
		    if (iVar3 == 0) goto code_r0x8126f6f7;
		    piVar5 = local_8._4_4_;
		    iVar6 = *local_8._4_4_;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_IDisposable_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x8126f644;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        System_IDisposable_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8126f644:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar4,piVar5,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8126f6a1:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8126f6f7:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                        (*(undefined4 *)(param1 + 0x14),
		                         Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__get_Values__
		                        );
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_20,uVar2,
		                 Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AbstractAdPlacementManager__GetEnumerator__
		                );
		      local_30 = 0;
		      puStack_2c = &local_20;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_20,
		                           Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AbstractAdPlacementManager__MoveNext__
		                          );
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8126f810;
		        }
		        if (iVar3 == 0) goto code_r0x8126f8b2;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (*(undefined4 *)(*local_18._4_4_ + 0xf0),local_18._4_4_,
		                   *(undefined4 *)(*local_18._4_4_ + 0xf4));
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar6 != 1);
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8126f810:
		      iVar6 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x8126f8b2:
		          DAT_ram_009d3e38 = 0;
		          System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__Clear__);
		          System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                    (*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_uint__AbstractAdPlacementManager__Clear__
		                    );
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0xb,&local_30);
		      goto joined_r0x8126f89e;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 10,&local_30);
		joined_r0x8126f89e:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
