using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Animations;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.ArtifactDrop.Model
{
	// Token: 0x02000CC8 RID: 3272
	[Token(Token = "0x2000CC8")]
	public class ArtifactDropModel : AbstractModel
	{
		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001026")]
		public IAnimationProvider AnimationProvider
		{
			[Token(Token = "0x6004FA3")]
			[Address(RVA = "0x9DBC", Offset = "0x9DBC", VA = "0x9DBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x0000EA60 File Offset: 0x0000CC60
		// (set) Token: 0x06004FA5 RID: 20389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001027")]
		public bool UseAnimation
		{
			[Token(Token = "0x6004FA4")]
			[Address(RVA = "0x9DBD", Offset = "0x9DBD", VA = "0x9DBD")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004FA5")]
			[Address(RVA = "0x9DBE", Offset = "0x9DBE", VA = "0x9DBE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001028")]
		public Dictionary<DropTypes, ArtifactDropModel.ArtifactDrop> DropCache
		{
			[Token(Token = "0x6004FA6")]
			[Address(RVA = "0x9DBF", Offset = "0x9DBF", VA = "0x9DBF")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA7")]
		[Address(RVA = "0x9DC0", Offset = "0x9DC0", VA = "0x9DC0", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_ArtifactDrop_Model_ArtifactDropModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a589d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Animations_EmptyAnimationProvider_TypeInfo);
		    DAT_ram_00a589d9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Animations_EmptyAnimationProvider_TypeInfo);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop___ctor__
		            );
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  return;
		}
		*/

		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA8")]
		[Address(RVA = "0x9DC1", Offset = "0x9DC1", VA = "0x9DC1")]
		public ArtifactDropModel(UserData user, IDictProvider dictProvider, IAnimationProvider animationProvider)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_ArtifactDrop_Model_ArtifactDropModel___ctor
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 0x14),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0x9DC2", Offset = "0x9DC2", VA = "0x9DC2")]
		public bool TryGetDrop(DropTypes dropType, out ArtifactDropModel.ArtifactDrop drop)
		{
		/* --- GHIDRA: TryGetDrop ---
		undefined4
		Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a589db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_DropTypes__ArtifactDropModel_ArtifactDrop__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_DropTypes__ArtifactDropModel_ArtifactDrop__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_DropTypes__ArtifactDropModel_ArtifactDrop__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_DropTypes__ArtifactDropModel_ArtifactDrop__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Contains__);
		    DAT_ram_00a589db = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__GetEnumerator__
		            );
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x201,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_DropTypes__ArtifactDropModel_ArtifactDrop__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5a9d6:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80f5aa75:
		          DAT_ram_009d3e38 = 0;
		          *param3 = 0;
		          return 0;
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x202,&local_20);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(param1_00);
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
		    if (iVar2 == 0) goto code_r0x80f5aa75;
		    iVar2 = (int)local_8;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ca,
		                       *(undefined4 *)((int)local_8 + 0xc),param2,
		                       Method_System_Collections_Generic_List_ArtifactData__Contains__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f5a9d6;
		    }
		    if (iVar3 != 0) {
		      *param3 = iVar2;
		      return 1;
		    }
		  } while( true );
		}
		*/

		/* --- GHIDRA: TryGetDrop ---
		undefined4
		Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a589db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_DropTypes__ArtifactDropModel_ArtifactDrop__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_DropTypes__ArtifactDropModel_ArtifactDrop__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_DropTypes__ArtifactDropModel_ArtifactDrop__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_DropTypes__ArtifactDropModel_ArtifactDrop__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Contains__);
		    DAT_ram_00a589db = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__GetEnumerator__
		            );
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x201,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_DropTypes__ArtifactDropModel_ArtifactDrop__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5a9d6:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80f5aa75:
		          DAT_ram_009d3e38 = 0;
		          *param3 = 0;
		          return 0;
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x202,&local_20);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(param1_00);
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
		    if (iVar2 == 0) goto code_r0x80f5aa75;
		    iVar2 = (int)local_8;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ca,
		                       *(undefined4 *)((int)local_8 + 0xc),param2,
		                       Method_System_Collections_Generic_List_ArtifactData__Contains__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f5a9d6;
		    }
		    if (iVar3 != 0) {
		      *param3 = iVar2;
		      return 1;
		    }
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x6004FAA")]
		[Address(RVA = "0x9DC3", Offset = "0x9DC3", VA = "0x9DC3")]
		public bool TryGetDrop(ArtifactData artifactData, out ArtifactDropModel.ArtifactDrop drop)
		{
			return default(bool);
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAB")]
		[Address(RVA = "0x9DC4", Offset = "0x9DC4", VA = "0x9DC4")]
		public void SetDrop(ArtifactDropModel.ArtifactDrop drop)
		{
		/* --- GHIDRA: SetDrop ---
		void Gameplay_ArtifactDrop_Model_ArtifactDropModel__SetDrop
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a589dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__Remove__
		              );
		    DAT_ram_00a589dd = '\x01';
		  }
		  local_4 = 0;
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 0x14),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    System_Collections_Generic_Dictionary_Int32Enum__object___OnDeserialization
		              (*(undefined4 *)(param1 + 0x14),param2,
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__Remove__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAC")]
		[Address(RVA = "0x9DC5", Offset = "0x9DC5", VA = "0x9DC5")]
		public void Remove(DropTypes dropType)
		{
		/* --- GHIDRA: Remove ---
		void Gameplay_ArtifactDrop_Model_ArtifactDropModel__Remove(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a589de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__Clear__
		              );
		    DAT_ram_00a589de = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__Clear__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAD")]
		[Address(RVA = "0x9DC6", Offset = "0x9DC6", VA = "0x9DC6")]
		public void RemoveAll()
		{
		/* --- GHIDRA: RemoveAll ---
		void Gameplay_ArtifactDrop_Model_ArtifactDropModel__RemoveAll
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a589df == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    DAT_ram_00a589df = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  *(undefined1 *)(param1 + 0x10) = (undefined1)param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04002B63 RID: 11107
		[Token(Token = "0x4002B63")]
		[FieldOffset(Offset = "0xC")]
		private readonly IAnimationProvider _emptyAnimationProvider;

		// Token: 0x04002B64 RID: 11108
		[Token(Token = "0x4002B64")]
		[FieldOffset(Offset = "0x10")]
		private readonly IAnimationProvider _animationProvider;

		// Token: 0x04002B65 RID: 11109
		[Token(Token = "0x4002B65")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<DropTypes, ArtifactDropModel.ArtifactDrop> _cache;

		// Token: 0x04002B67 RID: 11111
		[Token(Token = "0x4002B67")]
		[FieldOffset(Offset = "0x1C")]
		public readonly IDictProvider DictProvider;

		// Token: 0x02000CC9 RID: 3273
		[Token(Token = "0x2000CC9")]
		public class ArtifactDrop
		{
			// Token: 0x06004FAE RID: 20398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FAE")]
			[Address(RVA = "0x9DC7", Offset = "0x9DC7", VA = "0x9DC7")]
			public ArtifactDrop(DropTypes dropType, bool limitExceeded)
			{
			}

			// Token: 0x04002B68 RID: 11112
			[Token(Token = "0x4002B68")]
			[FieldOffset(Offset = "0x8")]
			public readonly DropTypes DropType;

			// Token: 0x04002B69 RID: 11113
			[Token(Token = "0x4002B69")]
			[FieldOffset(Offset = "0xC")]
			public readonly List<ArtifactData> Artifacts;

			// Token: 0x04002B6A RID: 11114
			[Token(Token = "0x4002B6A")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool LimitExceeded;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DropCache ---
		void Gameplay_ArtifactDrop_Model_ArtifactDropModel__get_DropCache(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a589de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__Clear__
		              );
		    DAT_ram_00a589de = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__Clear__
		            );
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
