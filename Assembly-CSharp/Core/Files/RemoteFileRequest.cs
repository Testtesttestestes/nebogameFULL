using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Log.Files;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine.Networking;

namespace Core.Files
{
	// Token: 0x02000EF9 RID: 3833
	[Token(Token = "0x2000EF9")]
	public class RemoteFileRequest : IFileInfo, IFileContent
	{
		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06005CEF RID: 23791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012C7")]
		public string Path
		{
			[Token(Token = "0x6005CEF")]
			[Address(RVA = "0xA978", Offset = "0xA978", VA = "0xA978", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		[Token(Token = "0x170012C8")]
		public bool CacheOnDevice
		{
			[Token(Token = "0x6005CF0")]
			[Address(RVA = "0xA979", Offset = "0xA979", VA = "0xA979", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06005CF1 RID: 23793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012C9")]
		public IFileInfo FileInfo
		{
			[Token(Token = "0x6005CF1")]
			[Address(RVA = "0xA97A", Offset = "0xA97A", VA = "0xA97A", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005CF3 RID: 23795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012CA")]
		[CanBeNull]
		public UnityWebRequest UwRequest
		{
			[Token(Token = "0x6005CF2")]
			[Address(RVA = "0xA97B", Offset = "0xA97B", VA = "0xA97B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CF3")]
			[Address(RVA = "0xA97C", Offset = "0xA97C", VA = "0xA97C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06005CF4 RID: 23796 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		// (set) Token: 0x06005CF5 RID: 23797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012CB")]
		public int Attempt
		{
			[Token(Token = "0x6005CF4")]
			[Address(RVA = "0xA97D", Offset = "0xA97D", VA = "0xA97D")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005CF5")]
			[Address(RVA = "0xA97E", Offset = "0xA97E", VA = "0xA97E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		[Token(Token = "0x6005CF6")]
		[Address(RVA = "0xA97F", Offset = "0xA97F", VA = "0xA97F")]
		public float GetDelayForAttempt()
		{
		/* --- GHIDRA: GetDelayForAttempt ---
		void Core_Files_RemoteFileRequest__GetDelayForAttempt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5acc5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Action_IFileContent____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_LinkedList_Action_IFileContent___TypeInfo);
		    DAT_ram_00a5acc5 = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = 0x40000000;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_LinkedList_Action_IFileContent___TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  *(undefined1 *)(param1 + 0x1c) = (undefined1)param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined4 *)(param1 + 0xc) = param4;
		  if (DAT_ram_00a5acc7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Action_IFileContent___AddLast__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Action_IFileContent___Contains__);
		    DAT_ram_00a5acc7 = '\x01';
		  }
		  iVar2 = System_Collections_Generic_LinkedList_object____ctor
		                    (*(undefined4 *)(param1 + 0x18),param5,
		                     Method_System_Collections_Generic_LinkedList_Action_IFileContent___Contains__);
		  if (iVar2 == 0) {
		    System_Collections_Generic_LinkedList_object____ctor
		              (*(undefined4 *)(param1 + 0x18),param5,
		               Method_System_Collections_Generic_LinkedList_Action_IFileContent___AddLast__);
		  }
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF7")]
		[Address(RVA = "0xA980", Offset = "0xA980", VA = "0xA980")]
		public RemoteFileRequest(Uri uri, bool cacheOnDevice, int numberOfAttempts, Action<IFileContent> callback)
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Files_RemoteFileRequest___ctor(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(param1 + 0xc) < *(int *)(param1 + 0x24));
		}
		*/

		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06005CF8 RID: 23800 RVA: 0x00010B00 File Offset: 0x0000ED00
		[Token(Token = "0x170012CC")]
		public bool IsExpired
		{
			[Token(Token = "0x6005CF8")]
			[Address(RVA = "0xA981", Offset = "0xA981", VA = "0xA981")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF9")]
		[Address(RVA = "0xA982", Offset = "0xA982", VA = "0xA982")]
		public void RunRequest(UnityWebRequest request)
		{
		/* --- GHIDRA: RunRequest ---
		void Core_Files_RemoteFileRequest__RunRequest(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5acc6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_Enumerator_Action_IFileContent___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_Enumerator_Action_IFileContent___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_Enumerator_Action_IFileContent___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Action_IFileContent___Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Action_IFileContent___GetEnumerator__);
		    DAT_ram_00a5acc6 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  func_ii_16538(&local_18,*(undefined4 *)(param1 + 0x18),
		                Method_System_Collections_Generic_LinkedList_Action_IFileContent___GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                       Method_System_Collections_Generic_LinkedList_Enumerator_Action_IFileContent___MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c94f2;
		    }
		    if (iVar2 == 0) goto code_r0x812c9548;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(local_10._4_4_ + 0xc),*(undefined4 *)(local_10._4_4_ + 0x20),param1,
		               *(undefined4 *)(local_10._4_4_ + 0x14));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812c94f2:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
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
		code_r0x812c9548:
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		                (*(undefined4 *)(param1 + 0x18),
		                 Method_System_Collections_Generic_LinkedList_Action_IFileContent___Clear__);
		      *(undefined4 *)(param1 + 0x14) = 0;
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x75,&local_20);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0xA983", Offset = "0xA983", VA = "0xA983")]
		public void Complete()
		{
		/* --- GHIDRA: Complete ---
		uint Core_Files_RemoteFileRequest__Complete(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  if (DAT_ram_00a5acc7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Action_IFileContent___AddLast__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Action_IFileContent___Contains__);
		    DAT_ram_00a5acc7 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_LinkedList_object____ctor
		                    (*(undefined4 *)(param1 + 0x18),param2,
		                     Method_System_Collections_Generic_LinkedList_Action_IFileContent___Contains__);
		  if (uVar1 == 0) {
		    System_Collections_Generic_LinkedList_object____ctor
		              (*(undefined4 *)(param1 + 0x18),param2,
		               Method_System_Collections_Generic_LinkedList_Action_IFileContent___AddLast__);
		  }
		  return uVar1 ^ 1;
		}
		*/

		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x00010B18 File Offset: 0x0000ED18
		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0xA984", Offset = "0xA984", VA = "0xA984")]
		public bool TryAddCallback(Action<IFileContent> callback)
		{
		/* --- GHIDRA: TryAddCallback ---
		undefined4 Core_Files_RemoteFileRequest__TryAddCallback(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (*(int *)(param1 + 0x20) == 0) {
		    *param2 = 0;
		  }
		  else {
		    iVar1 = UnityEngine_AsyncOperation__get_isDone(*(int *)(param1 + 0x20),0);
		    if (*(int *)(param1 + 0x20) == 0) {
		      iVar2 = 0;
		    }
		    else {
		      iVar2 = *(int *)(*(int *)(param1 + 0x20) + 0xc);
		      if (iVar2 == 0) {
		        iVar2 = 0;
		      }
		      else {
		        iVar2 = UnityEngine_Networking_DownloadHandler__Dispose(iVar2,0);
		      }
		    }
		    *param2 = iVar2;
		    if ((iVar1 == 1) && (*param2 != 0)) {
		      return 1;
		    }
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x00010B30 File Offset: 0x0000ED30
		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0xA985", Offset = "0xA985", VA = "0xA985", Slot = "8")]
		private bool TryGetContent(out byte[] bytes)
		{
			return default(bool);
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CFD")]
		[Address(RVA = "0xA986", Offset = "0xA986", VA = "0xA986", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		uint Core_Files_RemoteFileRequest__ToString
		               (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  uint uVar1;
		  
		  param1_00 = 0;
		  if (*(int *)(param1 + 0x20) != 0) {
		    param1_00 = UnityEngine_Networking_UnityWebRequest__InternalSetRequestHeader
		                          (*(int *)(param1 + 0x20),param2,0);
		  }
		  *param3 = param1_00;
		  uVar1 = func_ii_4769(param1_00,0);
		  return uVar1 ^ 1;
		}
		*/

			return null;
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x00010B48 File Offset: 0x0000ED48
		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0xA987", Offset = "0xA987", VA = "0xA987", Slot = "6")]
		public bool TryGetResponseHeader(string key, out string value)
		{
		/* --- GHIDRA: TryGetResponseHeader ---
		int Core_Files_RemoteFileRequest__TryGetResponseHeader
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5acc9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Files_WebGL_FileManager__Complete_d__1_TypeInfo);
		    DAT_ram_00a5acc9 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Files_WebGL_FileManager__Complete_d__1_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		[FieldOffset(Offset = "0x8")]
		public readonly float DefaultDelayForAttempt;

		// Token: 0x040032BB RID: 12987
		[Token(Token = "0x40032BB")]
		[FieldOffset(Offset = "0xC")]
		public readonly int NumberOfAttempts;

		// Token: 0x040032BC RID: 12988
		[Token(Token = "0x40032BC")]
		[FieldOffset(Offset = "0x10")]
		public readonly Uri Uri;

		// Token: 0x040032BD RID: 12989
		[Token(Token = "0x40032BD")]
		[FieldOffset(Offset = "0x14")]
		[CanBeNull]
		public FileDownloadLogger FileDownloadLogger;

		// Token: 0x040032BE RID: 12990
		[Token(Token = "0x40032BE")]
		[FieldOffset(Offset = "0x18")]
		private readonly LinkedList<Action<IFileContent>> _callbacks;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Attempt ---
		float Core_Files_RemoteFileRequest__set_Attempt(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5acc4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5acc4 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x24);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar1 = System_Math__Log10((double)(1.0 - (float)iVar2),3.0,0);
		  return (float)(1.0 - dVar1) / 1000.0;
		}
		*/


		/* --- GHIDRA: get_IsExpired ---
		void Core_Files_RemoteFileRequest__get_IsExpired(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x20) = param2;
		  *(int *)(param1 + 0x24) = *(int *)(param1 + 0x24) + 1;
		  return;
		}
		*/


		/* --- GHIDRA: Core.Files.IFileContent.TryGetContent ---
		undefined4
		Core_Files_RemoteFileRequest__Core_Files_IFileContent_TryGetContent(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param4;
		  undefined8 param2_00;
		  int iVar4;
		  ushort uVar5;
		  ushort local_28;
		  undefined6 uStack_26;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined1 local_12;
		  undefined1 local_11;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5acc8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_UnityWebRequest_Result___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Nullable_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Nullable_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Nullable_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Nullable_UnityWebRequest_Result__TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16844);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16840);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9854);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16842);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16841);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8885);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4537);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1261);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16845);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16843);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28690);
		    DAT_ram_00a5acc8 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  param1_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,0xf);
		  *(undefined4 *)(param1_00 + 0x10) = StringLiteral_8885;
		  uVar2 = func_ii_8749(*(undefined4 *)(param1 + 0x10),0);
		  *(undefined4 *)(param1_00 + 0x14) = uVar2;
		  *(undefined4 *)(param1_00 + 0x18) = StringLiteral_1261;
		  uVar2 = System_Uri__TryCreate(*(undefined4 *)(param1 + 0x10),0x10,2,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  *(undefined4 *)(param1_00 + 0x20) = StringLiteral_1238;
		  local_11 = *(undefined1 *)(param1 + 0x1c);
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_11);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28690,StringLiteral_4537,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x24) = uVar2;
		  local_12 = *(int *)(param1 + 0xc) < *(int *)(param1 + 0x24);
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_12);
		  _local_28 = CONCAT44(uStack_26._2_4_,*(undefined4 *)(param1 + 0x24));
		  uVar3 = func_ii_1081(DAT_ram_00a66954,&local_28);
		  local_18 = *(undefined4 *)(param1 + 0xc);
		  param4 = func_ii_1081(DAT_ram_00a66954,&local_18);
		  uVar2 = func_ii_8529(StringLiteral_9854,uVar2,uVar3,param4,0);
		  *(undefined4 *)(param1_00 + 0x28) = uVar2;
		  uVar2 = StringLiteral_16843;
		  if (*(int *)(param1 + 0x20) == 0) {
		    local_8 = 0;
		    local_10 = 0;
		  }
		  else {
		    param2_00 = UnityEngine_Networking_UnityWebRequest__InternalSetUrl(*(int *)(param1 + 0x20),0);
		    local_20 = 0;
		    _local_28 = 0;
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (&local_28,param2_00,Method_System_Nullable_long___ctor__);
		    local_8 = local_20;
		    local_10 = _local_28;
		  }
		  local_20 = local_8;
		  _local_28 = local_10;
		  uVar3 = func_ii_1081(System_Nullable_long__TypeInfo,&local_28);
		  uVar2 = func_ii_4419(uVar2,uVar3,0);
		  *(undefined4 *)(param1_00 + 0x2c) = uVar2;
		  *(undefined4 *)(param1_00 + 0x30) = StringLiteral_16841;
		  if (*(int *)(param1 + 0x20) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = UnityEngine_Networking_UnityWebRequest__get_url(*(int *)(param1 + 0x20),0);
		  }
		  *(undefined4 *)(param1_00 + 0x34) = uVar2;
		  *(undefined4 *)(param1_00 + 0x38) = StringLiteral_1238;
		  uVar2 = StringLiteral_16844;
		  if (*(int *)(param1 + 0x20) == 0) {
		    _local_28 = 0;
		  }
		  else {
		    uVar3 = UnityEngine_AsyncOperation__get_isDone(*(int *)(param1 + 0x20),0);
		    _local_28 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor
		              (&local_28,uVar3,Method_System_Nullable_UnityWebRequest_Result___ctor__);
		  }
		  uVar3 = func_ii_1081(System_Nullable_UnityWebRequest_Result__TypeInfo,&local_28);
		  uVar2 = func_ii_4419(uVar2,uVar3,0);
		  *(undefined4 *)(param1_00 + 0x3c) = uVar2;
		  uVar2 = StringLiteral_16845;
		  if (*(int *)(param1 + 0x20) == 0) {
		    _local_28 = 0;
		  }
		  else {
		    uVar3 = UnityEngine_Networking_UnityWebRequest__SetTimeoutMsec(*(int *)(param1 + 0x20),0);
		    _local_28 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor(&local_28,uVar3,Method_System_Nullable_int___ctor__);
		  }
		  uVar3 = func_ii_1081(System_Nullable_int__TypeInfo,&local_28);
		  uVar2 = func_ii_4419(uVar2,uVar3,0);
		  *(undefined4 *)(param1_00 + 0x40) = uVar2;
		  uVar2 = StringLiteral_16842;
		  if (*(int *)(param1 + 0x20) == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar3 = UnityEngine_Networking_UnityWebRequest__get_isModifiable(*(int *)(param1 + 0x20),0);
		    _local_28 = _local_28 & 0xffffffffffff0000;
		    System_Data_SqlTypes_SqlByte__ToSqlInt64(&local_28,uVar3,Method_System_Nullable_bool___ctor__);
		    uVar5 = local_28;
		  }
		  _local_28 = CONCAT62(uStack_26,uVar5);
		  uVar3 = func_ii_1081(System_Nullable_bool__TypeInfo,&local_28);
		  uVar2 = func_ii_4419(uVar2,uVar3,0);
		  *(undefined4 *)(param1_00 + 0x44) = uVar2;
		  uVar2 = StringLiteral_16840;
		  bVar1 = true;
		  if ((*(int *)(param1 + 0x20) != 0) &&
		     (iVar4 = *(int *)(*(int *)(param1 + 0x20) + 0xc), bVar1 = true, iVar4 != 0)) {
		    iVar4 = UnityEngine_Networking_DownloadHandler__Dispose(iVar4,0);
		    bVar1 = iVar4 == 0;
		  }
		  _local_28 = CONCAT71(stack0xffffffd9,bVar1);
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_28);
		  uVar2 = func_ii_4419(uVar2,uVar3,0);
		  *(undefined4 *)(param1_00 + 0x48) = uVar2;
		  uVar2 = System_Single__ToString(param1_00,0);
		  return uVar2;
		}
		*/

}
