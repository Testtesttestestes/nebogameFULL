using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.User;
using DefaultNamespace;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Tutorial.Guide.Model
{
	// Token: 0x0200047B RID: 1147
	[Token(Token = "0x200047B")]
	public class GuideModel : AbstractModel
	{
		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x170004BE")]
		public bool Enabled
		{
			[Token(Token = "0x6001B2C")]
			[Address(RVA = "0x6CB6", Offset = "0x6CB6", VA = "0x6CB6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x00005BC8 File Offset: 0x00003DC8
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BF")]
		public bool DevEditorToolEnabled
		{
			[Token(Token = "0x6001B2D")]
			[Address(RVA = "0x6CB7", Offset = "0x6CB7", VA = "0x6CB7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B2E")]
			[Address(RVA = "0x6CB8", Offset = "0x6CB8", VA = "0x6CB8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C0")]
		public RepeatedField<TutorialStepDic> StepsDicts
		{
			[Token(Token = "0x6001B2F")]
			[Address(RVA = "0x6CB9", Offset = "0x6CB9", VA = "0x6CB9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B30")]
			[Address(RVA = "0x6CBA", Offset = "0x6CBA", VA = "0x6CBA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C1")]
		public IGuideTarget CurrentTarget
		{
			[Token(Token = "0x6001B31")]
			[Address(RVA = "0x6CBB", Offset = "0x6CBB", VA = "0x6CBB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B32")]
			[Address(RVA = "0x6CBC", Offset = "0x6CBC", VA = "0x6CBC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C2")]
		public GuideConfig CurrentConfig
		{
			[Token(Token = "0x6001B33")]
			[Address(RVA = "0x6CBD", Offset = "0x6CBD", VA = "0x6CBD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B34")]
			[Address(RVA = "0x6CBE", Offset = "0x6CBE", VA = "0x6CBE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C3")]
		public IUserSettings UserSettings
		{
			[Token(Token = "0x6001B35")]
			[Address(RVA = "0x6CBF", Offset = "0x6CBF", VA = "0x6CBF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B36")]
			[Address(RVA = "0x6CC0", Offset = "0x6CC0", VA = "0x6CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00005BE0 File Offset: 0x00003DE0
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C4")]
		public uint CurrentTutorialId
		{
			[Token(Token = "0x6001B37")]
			[Address(RVA = "0x6CC1", Offset = "0x6CC1", VA = "0x6CC1")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001B38")]
			[Address(RVA = "0x6CC2", Offset = "0x6CC2", VA = "0x6CC2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C5")]
		public GuideConfig PendingStep
		{
			[Token(Token = "0x6001B39")]
			[Address(RVA = "0x6CC3", Offset = "0x6CC3", VA = "0x6CC3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B3A")]
			[Address(RVA = "0x6CC4", Offset = "0x6CC4", VA = "0x6CC4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x6CC5", Offset = "0x6CC5", VA = "0x6CC5", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Tutorial_Guide_Model_GuideModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58486 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_GuideConfig___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_IGuideTarget___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_IGuideTarget__TypeInfo);
		    DAT_ram_00a58486 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		  System_Collections_Generic_HashSet_PropertyPath___get_Count
		            (uVar1,Method_System_Collections_Generic_HashSet_uint___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		  System_Collections_Generic_HashSet_PropertyPath___get_Count
		            (uVar1,Method_System_Collections_Generic_HashSet_uint___ctor__);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___TypeInfo
		                    );
		  Unity_Services_Core_Configuration_SerializableProjectConfiguration__get_Empty
		            (uVar1,0x32,
		             Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig____ctor__);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__List_GuideConfig___TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object____ctor
		            (uVar1,0x1e,
		             Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig____ctor__);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__List_GuideConfig___TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object____ctor
		            (uVar1,0x1e,
		             Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig____ctor__);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined1 *)(param1 + 0x14) = (undefined1)param4;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_IGuideTarget__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_IGuideTarget___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param5;
		  *(undefined4 *)(param1 + 0x20) = param3;
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x6CC6", Offset = "0x6CC6", VA = "0x6CC6")]
		public GuideModel(UserData user, RepeatedField<TutorialStepDic> steps, bool systemEnabled, IUserSettings userSettings)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Tutorial_Guide_Model_GuideModel___ctor
		          (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int local_2c;
		  undefined1 *puStack_28;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined1 local_18 [8];
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58487 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___TryGetValue__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_GuideConfig___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Concat_GuideConfig___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Empty_GuideConfig___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_GuideConfig___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_uint__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_uint__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_uint__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_GuideConfig__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass42_0__TryGetGuideConfigs_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass42_0__TryGetGuideConfigs_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass42_0_TypeInfo);
		    DAT_ram_00a58487 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  local_1c = 0;
		  param3_00 = unnamed_function_1417
		                        (Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass42_0_TypeInfo);
		  *(undefined4 *)(param3_00 + 8) = param2;
		  iVar5 = Method_System_Linq_Enumerable_Empty_GuideConfig___;
		  iVar3 = *(int *)(Method_System_Linq_Enumerable_Empty_GuideConfig___ + 0x1c);
		  if (iVar3 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (Method_System_Linq_Enumerable_Empty_GuideConfig___);
		    iVar3 = *(int *)(iVar5 + 0x1c);
		  }
		  iVar3 = *(int *)(iVar3 + 8);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  if (*(int *)(iVar3 + 0x74) == 0) {
		    func_ii_306000(iVar3);
		  }
		  iVar5 = *(int *)(*(int *)(iVar5 + 0x1c) + 8);
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  *param3 = **(undefined4 **)(iVar5 + 0x5c);
		  Sirenix_Utilities_TypeExtensions__AreGenericConstraintsSatisfiedBy
		            (&local_2c,*(undefined4 *)(param1 + 0x3c),
		             Method_System_Collections_Generic_HashSet_uint__GetEnumerator__);
		  local_10 = local_24;
		  local_2c = 0;
		  puStack_28 = local_18;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x16d,local_18,
		                         Method_System_Collections_Generic_HashSet_Enumerator_uint__MoveNext__);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ef2d1c:
		        iVar5 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar5 == iVar3) {
		          piVar2 = (int *)import::env::__cxa_begin_catch(uVar1);
		          iVar3 = *piVar2;
		          DAT_ram_009d3e38 = 0;
		          local_2c = iVar3;
		          import::env::invoke_v(0x123);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 != 1) {
		            if (iVar3 != 0) {
		              System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		              do {
		                halt_trap();
		              } while( true );
		            }
		code_r0x80ef2d72:
		            DAT_ram_009d3e38 = 0;
		            iVar5 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                              (*(undefined4 *)(param1 + 0x4c),*(undefined4 *)(param1 + 0x30),
		                               &local_4,
		                               Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___TryGetValue__
		                              );
		            uVar1 = local_4;
		            uVar4 = *param3;
		            if (iVar5 != 0) {
		              param1_00 = unnamed_function_1417(System_Func_GuideConfig__bool__TypeInfo);
		              System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                        (param1_00,param3_00,
		                         Method_Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass42_0__TryGetGuideConfigs_b__0__
		                         ,0);
		              uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                                (uVar1,param1_00,Method_System_Linq_Enumerable_Where_GuideConfig___)
		              ;
		              uVar4 = System_Collections_Generic_HashSet_Enumerator_uint___MoveNext
		                                (uVar4,uVar1,Method_System_Linq_Enumerable_Concat_GuideConfig___);
		              *param3 = uVar4;
		            }
		            iVar5 = System_Linq_Enumerable__OrderBy_object__ulong_
		                              (uVar4,Method_System_Linq_Enumerable_Any_GuideConfig___);
		            if (iVar5 == 0) {
		              iVar5 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                                (*(undefined4 *)(param1 + 0x44),*(undefined4 *)(param3_00 + 8),
		                                 &local_8,
		                                 Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___TryGetValue__
		                                );
		              if (iVar5 == 0) {
		                uVar1 = *param3;
		              }
		              else {
		                *param3 = local_8;
		                uVar1 = local_8;
		              }
		              uVar1 = System_Linq_Enumerable__OrderBy_object__ulong_
		                                (uVar1,Method_System_Linq_Enumerable_Any_GuideConfig___);
		            }
		            else {
		              uVar1 = 1;
		            }
		            return uVar1;
		          }
		          uVar1 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x16f,&local_2c);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		          import::env::__resumeException(uVar1);
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
		      if (iVar3 == 0) goto code_r0x80ef2d72;
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39d,
		                         *(undefined4 *)(param1 + 0x4c),local_10._4_4_,&local_1c,
		                         Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___TryGetValue__
		                        );
		      uVar1 = local_1c;
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef2d1c;
		      }
		    } while (iVar3 == 0);
		    uVar4 = *param3;
		    iVar5 = *(int *)(param3_00 + 0xc);
		    if (iVar5 == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_GuideConfig__bool__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,iVar5,param3_00,
		                   Method_Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass42_0__TryGetGuideConfigs_b__1__
		                   ,0);
		        if (DAT_ram_009d3e38 != 1) {
		          *(int *)(param3_00 + 0xc) = iVar5;
		          goto code_r0x80ef2c65;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef2d1c;
		    }
		code_r0x80ef2c65:
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x226,uVar1,iVar5,
		                       Method_System_Linq_Enumerable_Where_GuideConfig___);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef2d1c;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x16e,uVar4,uVar1,
		                       Method_System_Linq_Enumerable_Concat_GuideConfig___);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef2d1c;
		    }
		    *param3 = uVar1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x6CC7", Offset = "0x6CC7", VA = "0x6CC7")]
		public bool TryGetGuideConfigs(string targetId, out IEnumerable<GuideConfig> configs)
		{
		/* --- GHIDRA: TryGetGuideConfigs ---
		void Gameplay_Tutorial_Guide_Model_GuideModel__TryGetGuideConfigs
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x38) = 0;
		  *(undefined4 *)(param1 + 0x30) = param2;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x6CC8", Offset = "0x6CC8", VA = "0x6CC8")]
		public void StartTutorial(uint tutorialId)
		{
		/* --- GHIDRA: StartTutorial ---
		void Gameplay_Tutorial_Guide_Model_GuideModel__StartTutorial(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58488 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Add__);
		    DAT_ram_00a58488 = '\x01';
		  }
		  UnityEngine_TextCore_LowLevel_FontEngine__GetGlyphIndex
		            (*(undefined4 *)(param1 + 0x40),*(undefined4 *)(param1 + 0x30),
		             Method_System_Collections_Generic_HashSet_uint__Add__);
		  *(undefined4 *)(param1 + 0x38) = 0;
		  *(undefined8 *)(param1 + 0x30) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x6CC9", Offset = "0x6CC9", VA = "0x6CC9")]
		public void FinishTutorial()
		{
		/* --- GHIDRA: FinishTutorial ---
		undefined4
		Gameplay_Tutorial_Guide_Model_GuideModel__FinishTutorial
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58489 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Add__);
		    DAT_ram_00a58489 = '\x01';
		  }
		  uVar1 = UnityEngine_TextCore_LowLevel_FontEngine__GetGlyphIndex
		                    (*(undefined4 *)(param1 + 0x3c),param2,
		                     Method_System_Collections_Generic_HashSet_uint__Add__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x6CCA", Offset = "0x6CCA", VA = "0x6CCA")]
		public bool AddToWhiteList(uint tutorialId)
		{
		/* --- GHIDRA: AddToWhiteList ---
		undefined4
		Gameplay_Tutorial_Guide_Model_GuideModel__AddToWhiteList(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int local_4;
		  
		  if (DAT_ram_00a5848a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___TryGetValue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GuideConfig__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GuideConfig__get_Item__);
		    DAT_ram_00a5848a = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(param1 + 0x34) == 0) {
		    *param2 = 0;
		    *(int *)(param1 + 0x38) = *(int *)(param1 + 0x38) + 1;
		    iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                      (*(undefined4 *)(param1 + 0x4c),*(undefined4 *)(param1 + 0x30),&local_4,
		                       Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___TryGetValue__
		                      );
		    if (iVar1 == 0) {
		      local_4 = System_Collections_Generic_List_object___get_Item
		                          (*(undefined4 *)(param1 + 0x48),*(undefined4 *)(param1 + 0x30),
		                           Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Item__
		                          );
		    }
		    if (*(int *)(local_4 + 0xc) <= *(int *)(param1 + 0x38)) {
		      return 0;
		    }
		    iVar1 = System_Linq_Enumerable__ToList_object_
		                      (local_4,*(int *)(param1 + 0x38),
		                       Method_System_Collections_Generic_List_GuideConfig__get_Item__);
		    *param2 = iVar1;
		  }
		  else {
		    *param2 = *(int *)(param1 + 0x34);
		    *(undefined4 *)(param1 + 0x34) = 0;
		  }
		  return 1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0x6CCB", Offset = "0x6CCB", VA = "0x6CCB")]
		public bool TryMoveToNextStep(out GuideConfig config)
		{
		/* --- GHIDRA: TryMoveToNextStep ---
		/* WARNING: Removing unreachable block (ram,0x80ef31a6) */
		
		int Gameplay_Tutorial_Guide_Model_GuideModel__TryMoveToNextStep
		              (int param1,undefined4 param2,int *param3,int *param4,undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5848b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_IGuideTarget___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_uint__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_uint__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_uint__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_IGuideTarget__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GuideConfig__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass47_0__TryCheckWhiteList_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass47_0_TypeInfo);
		    DAT_ram_00a5848b = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *param3 = 0;
		  *param4 = 0;
		  Sirenix_Utilities_TypeExtensions__AreGenericConstraintsSatisfiedBy
		            (&local_10,*(undefined4 *)(param1 + 0x3c),
		             Method_System_Collections_Generic_HashSet_uint__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x16d,&local_10,
		                       Method_System_Collections_Generic_HashSet_Enumerator_uint__MoveNext__);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef332b;
		    }
		    if (iVar1 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = local_8._4_4_;
		    iVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass47_0_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef332b;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                       *(undefined4 *)(param1 + 0x4c),uVar5,
		                       Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Item__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef332b;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22a,uVar5,0,
		                       Method_System_Collections_Generic_List_GuideConfig__get_Item__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef332b;
		    }
		    *param3 = iVar3;
		    *(undefined4 *)(iVar2 + 8) = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0x18);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_IGuideTarget__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar5,iVar2,
		               Method_Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass47_0__TryCheckWhiteList_b__0__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21c,param2,uVar5,
		                       Method_System_Linq_Enumerable_FirstOrDefault_IGuideTarget___);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef332b;
		    }
		    *param4 = iVar4;
		    if (iVar4 != 0) {
		      return iVar1;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ef332b:
		  iVar2 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar1) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar1 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar1 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return 0;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x170,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x6CCC", Offset = "0x6CCC", VA = "0x6CCC")]
		public bool TryCheckWhiteList(IEnumerable<IGuideTarget> targets, out GuideConfig config, out IGuideTarget target)
		{
		/* --- GHIDRA: TryCheckWhiteList ---
		/* WARNING: Removing unreachable block (ram,0x80ef356a) */
		
		int Gameplay_Tutorial_Guide_Model_GuideModel__TryCheckWhiteList
		              (int param1,undefined4 param2,int param3,int *param4,int *param5,undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5848c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Keys__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_IGuideTarget___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_GuideConfig___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_GuideConfig___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_GuideConfig___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_IGuideTarget__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_GuideConfig___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GuideConfig__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass48_0__TryCheckTutorials_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass48_0_TypeInfo);
		    DAT_ram_00a5848c = '\x01';
		  }
		  *param4 = 0;
		  *param5 = 0;
		  uVar1 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x48),
		                     Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar1,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_GuideConfig___GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  while( true ) {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,local_10,
		                         Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_GuideConfig___MoveNext__
		                        );
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3798;
		      }
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return 0;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar1 = local_8._4_4_;
		      iVar3 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass48_0_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3798;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3bc,
		                         *(undefined4 *)(param1 + 0x40),uVar1,
		                         Method_System_Collections_Generic_HashSet_uint__Contains__);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3798;
		      }
		    } while (iVar4 != 0);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                       *(undefined4 *)(param1 + 0x48),uVar1,
		                       Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Item__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef3798;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22a,uVar1,0,
		                       Method_System_Collections_Generic_List_GuideConfig__get_Item__);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef3798;
		    }
		    *param4 = iVar4;
		    *(undefined4 *)(iVar3 + 8) = *(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x18);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_IGuideTarget__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar1,iVar3,
		               Method_Gameplay_Tutorial_Guide_Model_GuideModel___c__DisplayClass48_0__TryCheckTutorials_b__0__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21c,param2,uVar1,
		                       Method_System_Linq_Enumerable_FirstOrDefault_IGuideTarget___);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef3798;
		    }
		    *param5 = iVar5;
		    if (iVar5 != 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (*(undefined4 *)(param3 + 0xc),*(undefined4 *)(param3 + 0x20),*param4,
		                         *(undefined4 *)(param3 + 0x14));
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3798;
		      }
		      if (iVar5 != 0) {
		        DAT_ram_009d3e38 = 0;
		        return iVar2;
		      }
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ef3798:
		  iVar3 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar2) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar2 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return 0;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x171,&local_20);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x6CCD", Offset = "0x6CCD", VA = "0x6CCD")]
		public bool TryCheckTutorials(IEnumerable<IGuideTarget> targets, Predicate<GuideConfig> predicate, out GuideConfig config, out IGuideTarget target)
		{
		/* --- GHIDRA: TryCheckTutorials ---
		/* WARNING: Removing unreachable block (ram,0x80ef3e3c) */
		/* WARNING: Removing unreachable block (ram,0x80ef3b62) */
		
		void Gameplay_Tutorial_Guide_Model_GuideModel__TryCheckTutorials(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  undefined4 param3;
		  undefined4 param2_00;
		  undefined8 uVar10;
		  int *piVar11;
		  uint uVar12;
		  int local_10;
		  int **local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5848d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___TryGetValue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_TutorialStepDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_GuideConfig__AddLast__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_GuideConfig___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_GuideConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GuideConfig__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TutorialStepDic__GetEnumerator__);
		    DAT_ram_00a5848d = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param1 + 0x20),
		                              Method_Google_Protobuf_Collections_RepeatedField_TutorialStepDic__GetEnumerator__
		                             );
		  local_10 = 0;
		  local_c = &local_4;
		code_r0x80ef3934:
		  do {
		    piVar7 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar12 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar2 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x80ef39da;
		        }
		        uVar12 = uVar12 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ef3a1e:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef3f38;
		    }
		code_r0x80ef39da:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ef3a1e;
		    if (iVar9 == 0) goto code_r0x80ef3f81;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar12 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8);
		        if (System_Collections_Generic_IEnumerator_TutorialStepDic__TypeInfo == *piVar11) {
		          puVar2 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x80ef3ac7;
		        }
		        uVar12 = uVar12 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_TutorialStepDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ef3bb6:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef3f38;
		    }
		code_r0x80ef3ac7:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ef3bb6;
		    uVar10 = *(undefined8 *)(iVar9 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef3f38;
		    }
		    *(int *)(iVar6 + 0x10) = iVar9;
		    *(undefined8 *)(iVar6 + 8) = uVar10;
		    if (*(int *)(iVar9 + 0x10) == 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x172,param1,iVar6,iVar9);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3f38;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39d,
		                       *(undefined4 *)(param1 + 0x4c),*(undefined4 *)(iVar9 + 0xc),&local_8,
		                       Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___TryGetValue__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    iVar1 = Method_System_Collections_Generic_List_GuideConfig__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef3f38;
		    }
		    if (iVar4 == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                         *(undefined4 *)(param1 + 0x48),*(undefined4 *)(iVar9 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___get_Item__
		                        );
		      iVar5 = DAT_ram_009d3e38;
		      iVar1 = Method_System_Collections_Generic_List_GuideConfig__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3f38;
		      }
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar12 = *(uint *)(iVar4 + 0xc);
		      if (uVar12 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		        *(uint *)(iVar4 + 0xc) = uVar12 + 1;
		        *(int *)(*(int *)(iVar4 + 8) + uVar12 * 4 + 0x10) = iVar6;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar6,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ef3f38;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000f84 + 0xf7,
		                         *(undefined4 *)(param1 + 0x44),*(undefined4 *)(iVar9 + 0x18),
		                         Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___ContainsKey__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3f38;
		      }
		      if (iVar5 == 0) {
		        param3 = *(undefined4 *)(iVar9 + 0x18);
		        param2_00 = *(undefined4 *)(param1 + 0x44);
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_LinkedList_GuideConfig__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x4b,param2_00,param3,uVar3,
		                     Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___Add__
		                    );
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80ef3e9f;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3f38;
		      }
		code_r0x80ef3e9f:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ec,
		                         *(undefined4 *)(param1 + 0x44),*(undefined4 *)(iVar9 + 0x18),
		                         Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___get_Item__
		                        );
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3f38;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x174,uVar3,iVar6,
		                 Method_System_Collections_Generic_LinkedList_GuideConfig__AddLast__);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef3f38;
		      }
		      goto code_r0x80ef3934;
		    }
		    *(int *)(local_8 + 0x10) = *(int *)(local_8 + 0x10) + 1;
		    uVar12 = *(uint *)(local_8 + 0xc);
		    if (uVar12 < *(uint *)(*(int *)(local_8 + 8) + 0xc)) {
		      *(uint *)(local_8 + 0xc) = uVar12 + 1;
		      *(int *)(*(int *)(local_8 + 8) + uVar12 * 4 + 0x10) = iVar6;
		      goto code_r0x80ef3934;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,local_8,iVar6,
		               *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ef3f38:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_10 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80ef3f81:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_c;
		      if (piVar7 != (int *)0x0) {
		        uVar12 = 0;
		        iVar9 = *piVar7;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8)) {
		              puVar8 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80ef3ffc;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80ef3ffc:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      }
		      if (local_10 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x175,&local_10);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
		    import::env::__resumeException(uVar3);
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

			return default(bool);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x6CCE", Offset = "0x6CCE", VA = "0x6CCE")]
		public void PopulateTutorials()
		{
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x1CF9", Offset = "0x1CF9", VA = "0x1CF9")]
		[CompilerGenerated]
		private void <PopulateTutorials>g__AddTutorialEntry|49_0(GuideConfig config)
		{
		}

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0xC")]
		public Scenes[] ScenesForUnload;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x10")]
		public Scenes[] TargetScenes;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0x14")]
		public readonly bool SystemEnabled;

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		[FieldOffset(Offset = "0x18")]
		public readonly HashSet<IGuideTarget> Targets;

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x38")]
		private int _stepIndex;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0x3C")]
		public readonly HashSet<uint> WhiteList;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<uint> _completedTutorials;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x44")]
		private readonly Dictionary<string, LinkedList<GuideConfig>> _guideConfigsCache;

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<uint, List<GuideConfig>> _tutorials;

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<uint, List<GuideConfig>> _onDemandTutorials;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_PendingStep ---
		void Gameplay_Tutorial_Guide_Model_GuideModel__set_PendingStep(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58485 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___Clear__
		              );
		    DAT_ram_00a58485 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x28) = 0;
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x44),
		             Method_System_Collections_Generic_Dictionary_string__LinkedList_GuideConfig___Clear__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x48),
		             Method_System_Collections_Generic_Dictionary_uint__List_GuideConfig___Clear__);
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
