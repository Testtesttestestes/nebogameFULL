using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace DefaultNamespace
{
	// Token: 0x02000E4A RID: 3658
	[Token(Token = "0x2000E4A")]
	public class SceneAppManager
	{
		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060059A3 RID: 22947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001244")]
		public static SceneAppManager Instance
		{
			[Token(Token = "0x60059A3")]
			[Address(RVA = "0x4445", Offset = "0x4445", VA = "0x4445")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400021A RID: 538
		// (add) Token: 0x060059A4 RID: 22948 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060059A5 RID: 22949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400021A")]
		public event Action<string> SceneLoadedEvent
		{
			[Token(Token = "0x60059A4")]
			[Address(RVA = "0xA6CF", Offset = "0xA6CF", VA = "0xA6CF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60059A5")]
			[Address(RVA = "0xA6D0", Offset = "0xA6D0", VA = "0xA6D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400021B RID: 539
		// (add) Token: 0x060059A6 RID: 22950 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060059A7 RID: 22951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400021B")]
		public event Action<string> SceneUnloadedEvent
		{
			[Token(Token = "0x60059A6")]
			[Address(RVA = "0xA6D1", Offset = "0xA6D1", VA = "0xA6D1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60059A7")]
			[Address(RVA = "0xA6D2", Offset = "0xA6D2", VA = "0xA6D2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x060059A8 RID: 22952 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001245")]
		public List<Scenes> CurrentScenes
		{
			[Token(Token = "0x60059A8")]
			[Address(RVA = "0xA6D3", Offset = "0xA6D3", VA = "0xA6D3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x060059A9 RID: 22953 RVA: 0x0000FE70 File Offset: 0x0000E070
		// (set) Token: 0x060059AA RID: 22954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001246")]
		public bool EnableLoad
		{
			[Token(Token = "0x60059A9")]
			[Address(RVA = "0xA6D4", Offset = "0xA6D4", VA = "0xA6D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60059AA")]
			[Address(RVA = "0xA6D5", Offset = "0xA6D5", VA = "0xA6D5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059AB")]
		[Address(RVA = "0xA6D6", Offset = "0xA6D6", VA = "0xA6D6")]
		private SceneAppManager()
		{
		/* --- GHIDRA: .ctor ---
		void DefaultNamespace_SceneAppManager___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  *(undefined4 *)(param2 + 0x14) = 0;
		  *(undefined4 *)(param1 + 0x14) = 0;
		  if (DAT_ram_00a63c3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__get_Count__
		              );
		    DAT_ram_00a63c3b = '\x01';
		    if (*(int *)(param1 + 0x14) != 0) goto code_r0x82371cbe;
		  }
		  if (*(int *)(*(int *)(param1 + 0x18) + 0x14) != 0) {
		    uVar1 = func_ii_7387(*(int *)(param1 + 0x18),
		                         Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__
		                        );
		    *(undefined4 *)(param1 + 0x14) = uVar1;
		    DefaultNamespace_SceneAppManager__HandleQueue(param1,uVar1,param1);
		  }
		code_r0x82371cbe:
		  param2_00 = *(int *)(param1 + 8);
		  if (param2_00 != 0) {
		    uVar1 = DefaultNamespace_SceneAppManager_SceneRequestData___ctor(param2,param2_00);
		    (**(code **)((ulonglong)*(uint *)(param2_00 + 0xc) * 4))
		              (*(undefined4 *)(param2_00 + 0x20),uVar1,*(undefined4 *)(param2_00 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060059AC RID: 22956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059AC")]
		[Address(RVA = "0xA6D7", Offset = "0xA6D7", VA = "0xA6D7")]
		private void CompleteLoad([NotNull] SceneAppManager.SceneRequestData request)
		{
		/* --- GHIDRA: CompleteLoad ---
		void DefaultNamespace_SceneAppManager__CompleteLoad(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  *(undefined4 *)(param2 + 0x14) = 0;
		  *(undefined4 *)(param1 + 0x14) = 0;
		  if (DAT_ram_00a63c3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__get_Count__
		              );
		    DAT_ram_00a63c3b = '\x01';
		    if (*(int *)(param1 + 0x14) != 0) goto code_r0x82371f18;
		  }
		  if (*(int *)(*(int *)(param1 + 0x18) + 0x14) != 0) {
		    uVar1 = func_ii_7387(*(int *)(param1 + 0x18),
		                         Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__
		                        );
		    *(undefined4 *)(param1 + 0x14) = uVar1;
		    DefaultNamespace_SceneAppManager__HandleQueue(param1,uVar1,param1);
		  }
		code_r0x82371f18:
		  param2_00 = *(int *)(param1 + 0xc);
		  if (param2_00 != 0) {
		    uVar1 = DefaultNamespace_SceneAppManager_SceneRequestData___ctor(param2,param2_00);
		    (**(code **)((ulonglong)*(uint *)(param2_00 + 0xc) * 4))
		              (*(undefined4 *)(param2_00 + 0x20),uVar1,*(undefined4 *)(param2_00 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060059AD RID: 22957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059AD")]
		[Address(RVA = "0xA6D8", Offset = "0xA6D8", VA = "0xA6D8")]
		private void CompleteUnload([NotNull] SceneAppManager.SceneRequestData request)
		{
		/* --- GHIDRA: CompleteUnload ---
		void DefaultNamespace_SceneAppManager__CompleteUnload
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63c38 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Enqueue__)
		    ;
		    DAT_ram_00a63c38 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x18),param2,
		             Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Enqueue__);
		  if (DAT_ram_00a63c3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__get_Count__
		              );
		    DAT_ram_00a63c3b = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) == 0) && (*(int *)(*(int *)(param1 + 0x18) + 0x14) != 0)) {
		    param2_00 = func_ii_7387(*(int *)(param1 + 0x18),
		                             Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__
		                            );
		    *(undefined4 *)(param1 + 0x14) = param2_00;
		    DefaultNamespace_SceneAppManager__HandleQueue(param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060059AE RID: 22958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059AE")]
		[Address(RVA = "0xA6D9", Offset = "0xA6D9", VA = "0xA6D9")]
		private void LoadScene(SceneAppManager.SceneRequestData value)
		{
		/* --- GHIDRA: LoadScene<__Il2CppFullySharedGenericType> ---
		int DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		              (int param1,undefined4 param2,undefined4 *param3,int param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  int iVar2;
		  int *local_4;
		  
		  if ((*(int *)(param4 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs__TryGetValue__
		                ), *(int *)(param4 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		  }
		  local_4 = (int *)0x0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs__TryGetValue__
		                    );
		  param1_00 = local_4;
		  if (iVar1 == 0) {
		    *param3 = 0;
		  }
		  else {
		    iVar2 = *(int *)(*(int *)(param4 + 0x1c) + 4);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) < (uint)*(byte *)(iVar2 + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) + (uint)*(byte *)(iVar2 + 0xb8) * 4 + -4) != iVar2)) {
		        System_Activator__CreateInstance(param1_00,iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    *param3 = param1_00;
		    iVar2 = *(int *)(*(int *)(param4 + 0x1c) + 4);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) < (uint)*(byte *)(iVar2 + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) + (uint)*(byte *)(iVar2 + 0xb8) * 4 + -4) != iVar2)) {
		        System_Activator__CreateInstance(param1_00,iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  return iVar1;
		}
		*/

		/* --- GHIDRA: LoadScene<object> ---
		void DefaultNamespace_SceneAppManager__LoadScene_object_
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63c93 == '\0') {
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		    DAT_ram_00a63c93 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(param2 + 8);
		  param1_00 = unnamed_function_1417(DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		  DefaultNamespace_SceneAppManager_SceneRequestData___ctor(param1_00,param2_00,1,param2,0);
		  DefaultNamespace_SceneAppManager__CompleteUnload(param1,param1_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: LoadScene ---
		void DefaultNamespace_SceneAppManager__LoadScene(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63c3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Enqueue__)
		    ;
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		    DAT_ram_00a63c3f = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = unnamed_function_1417(DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = 2;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (uVar1,param2_00,
		             Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Enqueue__);
		  if (DAT_ram_00a63c3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__get_Count__
		              );
		    DAT_ram_00a63c3b = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) == 0) && (*(int *)(*(int *)(param1 + 0x18) + 0x14) != 0)) {
		    uVar1 = func_ii_7387(*(int *)(param1 + 0x18),
		                         Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__
		                        );
		    *(undefined4 *)(param1 + 0x14) = uVar1;
		    DefaultNamespace_SceneAppManager__HandleQueue(param1,uVar1,uVar1);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: LoadScene ---
		void DefaultNamespace_SceneAppManager__LoadScene(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63c3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Enqueue__)
		    ;
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		    DAT_ram_00a63c3f = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = unnamed_function_1417(DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = 2;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (uVar1,param2_00,
		             Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Enqueue__);
		  if (DAT_ram_00a63c3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__get_Count__
		              );
		    DAT_ram_00a63c3b = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) == 0) && (*(int *)(*(int *)(param1 + 0x18) + 0x14) != 0)) {
		    uVar1 = func_ii_7387(*(int *)(param1 + 0x18),
		                         Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__
		                        );
		    *(undefined4 *)(param1 + 0x14) = uVar1;
		    DefaultNamespace_SceneAppManager__HandleQueue(param1,uVar1,uVar1);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: LoadScene ---
		void DefaultNamespace_SceneAppManager__LoadScene(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63c3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Enqueue__)
		    ;
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		    DAT_ram_00a63c3f = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = unnamed_function_1417(DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = 2;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (uVar1,param2_00,
		             Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Enqueue__);
		  if (DAT_ram_00a63c3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__get_Count__
		              );
		    DAT_ram_00a63c3b = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) == 0) && (*(int *)(*(int *)(param1 + 0x18) + 0x14) != 0)) {
		    uVar1 = func_ii_7387(*(int *)(param1 + 0x18),
		                         Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__
		                        );
		    *(undefined4 *)(param1 + 0x14) = uVar1;
		    DefaultNamespace_SceneAppManager__HandleQueue(param1,uVar1,uVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060059AF RID: 22959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059AF")]
		[Address(RVA = "0xA6DA", Offset = "0xA6DA", VA = "0xA6DA")]
		private IEnumerator LoadSceneRoutine(SceneAppManager.SceneRequestData request)
		{
		/* --- GHIDRA: LoadSceneRoutine ---
		int DefaultNamespace_SceneAppManager__LoadSceneRoutine
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63c3a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&DefaultNamespace_SceneAppManager__UnloadSceneRoutine_d__27_TypeInfo);
		    DAT_ram_00a63c3a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(DefaultNamespace_SceneAppManager__UnloadSceneRoutine_d__27_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059B0")]
		[Address(RVA = "0xA6DB", Offset = "0xA6DB", VA = "0xA6DB")]
		private IEnumerator UnloadSceneRoutine(SceneAppManager.SceneRequestData request)
		{
		/* --- GHIDRA: UnloadSceneRoutine ---
		void DefaultNamespace_SceneAppManager__UnloadSceneRoutine(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63c3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__get_Count__
		              );
		    DAT_ram_00a63c3b = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) == 0) && (*(int *)(*(int *)(param1 + 0x18) + 0x14) != 0)) {
		    param2_00 = func_ii_7387(*(int *)(param1 + 0x18),
		                             Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__Dequeue__
		                            );
		    *(undefined4 *)(param1 + 0x14) = param2_00;
		    DefaultNamespace_SceneAppManager__HandleQueue(param1,param2_00,param1);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B1")]
		[Address(RVA = "0xA6DC", Offset = "0xA6DC", VA = "0xA6DC")]
		private void HandleQueue()
		{
		/* --- GHIDRA: HandleQueue ---
		void DefaultNamespace_SceneAppManager__HandleQueue(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (*(int *)(param2 + 0xc) == 1) {
		    if (DAT_ram_00a63c39 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&DefaultNamespace_SceneAppManager__LoadSceneRoutine_d__26_TypeInfo);
		      DAT_ram_00a63c39 = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (DefaultNamespace_SceneAppManager__LoadSceneRoutine_d__26_TypeInfo);
		    *(undefined4 *)(param1_00 + 0x14) = param1;
		    *(undefined4 *)(param1_00 + 8) = 0;
		  }
		  else {
		    if (*(int *)(param2 + 0xc) != 2) {
		      return;
		    }
		    if (DAT_ram_00a63c3a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&DefaultNamespace_SceneAppManager__UnloadSceneRoutine_d__27_TypeInfo);
		      DAT_ram_00a63c3a = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (DefaultNamespace_SceneAppManager__UnloadSceneRoutine_d__27_TypeInfo);
		    *(undefined4 *)(param1_00 + 0x14) = param1;
		    *(undefined4 *)(param1_00 + 8) = 0;
		  }
		  *(int *)(param1_00 + 0x10) = param2;
		  Utils_CoroutineSource__GetMono(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B2")]
		[Address(RVA = "0xA6DD", Offset = "0xA6DD", VA = "0xA6DD")]
		private void HandleRequest(SceneAppManager.SceneRequestData request)
		{
		/* --- GHIDRA: HandleRequest ---
		void DefaultNamespace_SceneAppManager__HandleRequest(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63c3c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Scenes__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Scenes__Contains__);
		    DAT_ram_00a63c3c = '\x01';
		  }
		  iVar2 = Core_Data_Skills_UserSkillUtils__get_ExcludeUserSkillsIndexes
		                    (*(undefined4 *)(param1 + 0x10),param2,
		                     Method_System_Collections_Generic_List_Scenes__Contains__);
		  iVar1 = Method_System_Collections_Generic_List_Scenes__Add__;
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(param1 + 0x10);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar5 = *(uint *)(iVar2 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar5 * 4 + 0x10) = param2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    return;
		  }
		  local_4 = param2;
		  uVar3 = unnamed_function_2232(&DefaultNamespace_Scenes_TypeInfo);
		  uVar3 = func_ii_1081(uVar3,&local_4);
		  uVar4 = unnamed_function_2232(&StringLiteral_16467);
		  uVar3 = func_ii_4419(uVar4,uVar3,0);
		  uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar4 = unnamed_function_1417(uVar4);
		  System_String__Concat(uVar4,uVar3,0);
		  uVar3 = unnamed_function_2232(&Method_DefaultNamespace_SceneAppManager_AddScene__);
		  func_ii_1050(uVar4,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0xA6DE", Offset = "0xA6DE", VA = "0xA6DE")]
		private void AddScene(Scenes scene)
		{
		/* --- GHIDRA: AddScene ---
		void DefaultNamespace_SceneAppManager__AddScene(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63c3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs__Remove__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Scenes__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Scenes__Remove__);
		    DAT_ram_00a63c3d = '\x01';
		  }
		  iVar1 = Core_Data_Skills_UserSkillUtils__get_ExcludeUserSkillsIndexes
		                    (*(undefined4 *)(param1 + 0x10),param2,
		                     Method_System_Collections_Generic_List_Scenes__Contains__);
		  if (iVar1 != 0) {
		    System_Collections_Generic_List_Int32Enum___IsCompatibleObject
		              (*(undefined4 *)(param1 + 0x10),param2,
		               Method_System_Collections_Generic_List_Scenes__Remove__);
		  }
		  iVar1 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x1c),param2,
		                     Method_System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs__ContainsKey__
		                    );
		  if (iVar1 != 0) {
		    System_Collections_Generic_Dictionary_Int32Enum__object___OnDeserialization
		              (*(undefined4 *)(param1 + 0x1c),param2,
		               Method_System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs__Remove__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0xA6DF", Offset = "0xA6DF", VA = "0xA6DF")]
		private void RemoveScene(Scenes scene)
		{
		/* --- GHIDRA: RemoveScene ---
		void DefaultNamespace_SceneAppManager__RemoveScene(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  iVar3 = 0;
		  iVar1 = *(int *)(param2 + 0xc);
		  if (0 < iVar1) {
		    do {
		      uVar2 = *(undefined4 *)(param2 + iVar3 * 4 + 0x10);
		      if (DAT_ram_00a63c3e == '\0') {
		        Mono_Security_ASN1__get_Item(&DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		        DAT_ram_00a63c3e = '\x01';
		      }
		      param2_00 = unnamed_function_1417(DefaultNamespace_SceneAppManager_SceneRequestData_TypeInfo);
		      *(undefined4 *)(param2_00 + 0xc) = 1;
		      *(undefined4 *)(param2_00 + 8) = uVar2;
		      DefaultNamespace_SceneAppManager__CompleteUnload(param1,param2_00,param2_00);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x0000FE88 File Offset: 0x0000E088
		[Token(Token = "0x60059B5")]
		public bool TryGetSceneArgs<T>(Scenes scene, out SceneAppManager.SceneArgs<T> sceneArgs)
		{
		/* --- GHIDRA: TryGetSceneArgs<__Il2CppFullySharedGenericType> ---
		int * DefaultNamespace_SceneAppManager__TryGetSceneArgs___Il2CppFullySharedGenericType_
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5)
		
		{
		  short sVar1;
		  short sVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  int param1_01;
		  int param1_02;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar3 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar3 = Core_Net_SrvCommand___ctor(uVar4,(int)(short)param3,param4,0);
		    *(undefined4 *)(iVar3 + 0x14) = param2;
		    uVar4 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar4,param1,*(undefined4 *)(*param1 + 0xec),0);
		    param1_01 = **(int **)(param5 + 0x1c);
		    if (*(int *)(param1_01 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param1_01);
		    }
		    *(undefined4 *)(iVar3 + 0x34) = uVar4;
		    sVar1 = *(short *)(iVar3 + 0x12);
		    sVar2 = *(short *)(iVar3 + 0x10);
		    param1_02 = **(int **)(param1_01 + 0x1c);
		    if ((*(byte *)(param1_02 + 0xbd) & 1) == 0) {
		      param1_02 = func_ii_1079(param1_02);
		    }
		    uVar4 = unnamed_function_1417(param1_02);
		    UnityEngine_Purchasing_Default_Factory__Create
		              (uVar4,(int)sVar2,(int)sVar1,*(undefined4 *)(*(int *)(param1_01 + 0x1c) + 4));
		    *(undefined4 *)(iVar3 + 0x38) = uVar4;
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar3,0);
		  }
		  return param1_00;
		}
		*/

			return default(bool);
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B6")]
		[Address(RVA = "0xA6E0", Offset = "0xA6E0", VA = "0xA6E0")]
		public void LoadScene(params Scenes[] scenes)
		{
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B7")]
		[Address(RVA = "0xA6E1", Offset = "0xA6E1", VA = "0xA6E1")]
		public void LoadScene(Scenes scene)
		{
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B8")]
		public void LoadScene<TArgs>(SceneAppManager.SceneArgs<TArgs> sceneWhitArgs)
		{
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B9")]
		[Address(RVA = "0xA6E2", Offset = "0xA6E2", VA = "0xA6E2")]
		public void UnloadScene(Scenes scene)
		{
		/* --- GHIDRA: UnloadScene ---
		void DefaultNamespace_SceneAppManager__UnloadScene(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param3_00;
		  
		  if (0 < *(int *)(param2 + 0xc)) {
		    param3_00 = 0;
		    do {
		      DefaultNamespace_SceneAppManager__LoadScene
		                (param1,*(undefined4 *)(param2 + param3_00 * 4 + 0x10),param3_00);
		      param3_00 = param3_00 + 1;
		    } while (param3_00 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: UnloadScene ---
		void DefaultNamespace_SceneAppManager__UnloadScene(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param3_00;
		  
		  if (0 < *(int *)(param2 + 0xc)) {
		    param3_00 = 0;
		    do {
		      DefaultNamespace_SceneAppManager__LoadScene
		                (param1,*(undefined4 *)(param2 + param3_00 * 4 + 0x10),param3_00);
		      param3_00 = param3_00 + 1;
		    } while (param3_00 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060059BA RID: 22970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059BA")]
		[Address(RVA = "0xA6E3", Offset = "0xA6E3", VA = "0xA6E3")]
		public void UnloadScene(params Scenes[] scenes)
		{
		}

		// Token: 0x04003072 RID: 12402
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x0")]
		private static SceneAppManager _instance;

		// Token: 0x04003076 RID: 12406
		[Token(Token = "0x4003076")]
		[FieldOffset(Offset = "0x14")]
		private SceneAppManager.SceneRequestData _currentRequest;

		// Token: 0x04003077 RID: 12407
		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x18")]
		private readonly Queue<SceneAppManager.SceneRequestData> _requestQueue;

		// Token: 0x04003078 RID: 12408
		[Token(Token = "0x4003078")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<Scenes, SceneAppManager.SceneArgs> _sceneArgs;

		// Token: 0x02000E4B RID: 3659
		[Token(Token = "0x2000E4B")]
		public class SceneArgs
		{
			// Token: 0x060059BB RID: 22971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059BB")]
			[Address(RVA = "0xA6E4", Offset = "0xA6E4", VA = "0xA6E4")]
			protected SceneArgs(Scenes scene)
			{
			}

			// Token: 0x0400307A RID: 12410
			[Token(Token = "0x400307A")]
			[FieldOffset(Offset = "0x8")]
			public readonly Scenes Scene;
		}

		// Token: 0x02000E4C RID: 3660
		[Token(Token = "0x2000E4C")]
		public class SceneArgs<T> : SceneAppManager.SceneArgs
		{
			// Token: 0x060059BC RID: 22972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059BC")]
			public SceneArgs(Scenes scene, [NotNull] T data)
			{
			}

			// Token: 0x0400307B RID: 12411
			[Token(Token = "0x400307B")]
			[FieldOffset(Offset = "0x0")]
			[NotNull]
			public readonly T Data;
		}

		// Token: 0x02000E4D RID: 3661
		[Token(Token = "0x2000E4D")]
		private class SceneRequestData : IDisposable
		{
			// Token: 0x060059BD RID: 22973 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059BD")]
			[Address(RVA = "0xA6E5", Offset = "0xA6E5", VA = "0xA6E5")]
			public SceneRequestData(Scenes scene, SceneAppManager.SceneRequestData.RequestType type)
			{
			}

			// Token: 0x060059BE RID: 22974 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059BE")]
			[Address(RVA = "0xA6E6", Offset = "0xA6E6", VA = "0xA6E6")]
			public SceneRequestData(Scenes scene, SceneAppManager.SceneRequestData.RequestType type, SceneAppManager.SceneArgs sceneArgs)
			{
			}

			// Token: 0x060059BF RID: 22975 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60059BF")]
			[Address(RVA = "0xA6E7", Offset = "0xA6E7", VA = "0xA6E7")]
			public string GetSceneName()
			{
				return null;
			}

			// Token: 0x060059C0 RID: 22976 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
			[Token(Token = "0x60059C0")]
			[Address(RVA = "0xA6E8", Offset = "0xA6E8", VA = "0xA6E8")]
			public bool TryGetSceneArgs(out SceneAppManager.SceneArgs value)
			{
				return default(bool);
			}

			// Token: 0x060059C1 RID: 22977 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059C1")]
			[Address(RVA = "0xA6E9", Offset = "0xA6E9", VA = "0xA6E9", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0400307C RID: 12412
			[Token(Token = "0x400307C")]
			[FieldOffset(Offset = "0x8")]
			public readonly Scenes Scene;

			// Token: 0x0400307D RID: 12413
			[Token(Token = "0x400307D")]
			[FieldOffset(Offset = "0xC")]
			public readonly SceneAppManager.SceneRequestData.RequestType Type;

			// Token: 0x0400307E RID: 12414
			[Token(Token = "0x400307E")]
			[FieldOffset(Offset = "0x10")]
			private string _sceneName;

			// Token: 0x0400307F RID: 12415
			[Token(Token = "0x400307F")]
			[FieldOffset(Offset = "0x14")]
			private SceneAppManager.SceneArgs _sceneArgs;

			// Token: 0x02000E4E RID: 3662
			[Token(Token = "0x2000E4E")]
			public enum RequestType
			{
				// Token: 0x04003081 RID: 12417
				[Token(Token = "0x4003081")]
				AsyncLoad = 1,
				// Token: 0x04003082 RID: 12418
				[Token(Token = "0x4003082")]
				AsyncUnload
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Instance ---
		int * DefaultNamespace_SceneAppManager__get_Instance(int *param1)
		
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


		/* --- GHIDRA: add_SceneLoadedEvent ---
		void DefaultNamespace_SceneAppManager__add_SceneLoadedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63c34 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a63c34 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_SceneLoadedEvent ---
		void DefaultNamespace_SceneAppManager__remove_SceneLoadedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63c35 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a63c35 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_SceneUnloadedEvent ---
		void DefaultNamespace_SceneAppManager__add_SceneUnloadedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63c36 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a63c36 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_EnableLoad ---
		void DefaultNamespace_SceneAppManager__set_EnableLoad(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63c37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Scenes___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Scenes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__TypeInfo);
		    DAT_ram_00a63c37 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_Scenes__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_Scenes___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Queue_SceneAppManager_SceneRequestData__TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar1,Method_System_Collections_Generic_Queue_SceneAppManager_SceneRequestData___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_Scenes__SceneAppManager_SceneArgs___ctor__
		            );
		  *(undefined1 *)(param1 + 0x20) = 1;
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

}
