using System;
using System.Collections;
using System.Collections.Generic;
using Core.Log.Files;
using Il2CppDummyDll;

namespace Core.Files
{
	// Token: 0x02000EF1 RID: 3825
	[Token(Token = "0x2000EF1")]
	public abstract class AbstractFileManager : IFileManager
	{
		// Token: 0x06005CC2 RID: 23746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0xA955", Offset = "0xA955", VA = "0xA955")]
		protected AbstractFileManager(int timeout)
		{
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC3")]
		[Address(RVA = "0xA956", Offset = "0xA956", VA = "0xA956", Slot = "6")]
		public virtual void Load(string baseUri, string path, bool cacheOnDevice, Action<IFileContent> callback)
		{
		/* --- GHIDRA: Load ---
		void Core_Files_AbstractFileManager__Load(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5acbc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Files_AbstractFileManager__DownloadRoutine_d__10_TypeInfo);
		    DAT_ram_00a5acbc = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Files_AbstractFileManager__DownloadRoutine_d__10_TypeInfo);
		  *(undefined4 *)(param1_00 + 0x14) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  Utils_CoroutineSource__GetMono(param1_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: Load ---
		void Core_Files_AbstractFileManager__Load(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5acbc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Files_AbstractFileManager__DownloadRoutine_d__10_TypeInfo);
		    DAT_ram_00a5acbc = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Files_AbstractFileManager__DownloadRoutine_d__10_TypeInfo);
		  *(undefined4 *)(param1_00 + 0x14) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  Utils_CoroutineSource__GetMono(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC4")]
		[Address(RVA = "0xA957", Offset = "0xA957", VA = "0xA957", Slot = "5")]
		public void Load(string baseUri, string path, bool cacheOnDevice, Action<IFileContent> callback, FileDownloadLogger fileDownloadLogger)
		{
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x00010A10 File Offset: 0x0000EC10
		[Token(Token = "0x6005CC5")]
		[Address(RVA = "0x22C3", Offset = "0x22C3", VA = "0x22C3")]
		private bool TryLoad(string baseUri, string path, Action<IFileContent> callback, bool cacheOnDevice, out RemoteFileRequest fileRequest)
		{
		/* --- GHIDRA: TryLoad ---
		undefined4 Core_Files_AbstractFileManager__TryLoad(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a65576 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IO_FileStream_TypeInfo);
		    DAT_ram_00a65576 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_IO_FileStream_TypeInfo);
		  System_Uri__get_LocalPath(param1_00,param1,3,1,1,0);
		  return param1_00;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC6")]
		[Address(RVA = "0xA958", Offset = "0xA958", VA = "0xA958")]
		private void Download(RemoteFileRequest fileRequest)
		{
		/* --- GHIDRA: Download ---
		void Core_Files_AbstractFileManager__Download
		               (undefined4 param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5acbb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Files_AbstractFileManager__AwaitDownLoadRoutine_d__9_TypeInfo);
		    DAT_ram_00a5acbb = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Core_Files_AbstractFileManager__AwaitDownLoadRoutine_d__9_TypeInfo);
		  *(undefined4 *)(param1_00 + 0x18) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(float *)(param1_00 + 0x14) = param3;
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  Utils_CoroutineSource__GetMono(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC7")]
		[Address(RVA = "0xA959", Offset = "0xA959", VA = "0xA959")]
		private void ScheduleDownload(RemoteFileRequest request, float delaySeconds)
		{
		/* --- GHIDRA: ScheduleDownload ---
		int Core_Files_AbstractFileManager__ScheduleDownload
		              (undefined4 param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5acbb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Files_AbstractFileManager__AwaitDownLoadRoutine_d__9_TypeInfo);
		    DAT_ram_00a5acbb = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Files_AbstractFileManager__AwaitDownLoadRoutine_d__9_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x18) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x14) = param3;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CC8")]
		[Address(RVA = "0xA95A", Offset = "0xA95A", VA = "0xA95A")]
		private IEnumerator AwaitDownLoadRoutine(RemoteFileRequest request, float delaySeconds)
		{
		/* --- GHIDRA: AwaitDownLoadRoutine ---
		int Core_Files_AbstractFileManager__AwaitDownLoadRoutine
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5acbc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Files_AbstractFileManager__DownloadRoutine_d__10_TypeInfo);
		    DAT_ram_00a5acbc = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Files_AbstractFileManager__DownloadRoutine_d__10_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0xA95B", Offset = "0xA95B", VA = "0xA95B")]
		private IEnumerator DownloadRoutine(RemoteFileRequest request)
		{
		/* --- GHIDRA: DownloadRoutine ---
		int Core_Files_AbstractFileManager__DownloadRoutine
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5acbd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Files_AbstractFileManager__CompleteSuccessInternal_d__11_TypeInfo);
		    DAT_ram_00a5acbd = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Core_Files_AbstractFileManager__CompleteSuccessInternal_d__11_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0xA95C", Offset = "0xA95C", VA = "0xA95C")]
		private IEnumerator CompleteSuccessInternal(RemoteFileRequest request)
		{
		/* --- GHIDRA: CompleteSuccessInternal ---
		void Core_Files_AbstractFileManager__CompleteSuccessInternal
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5acbe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__RemoteFileRequest__Remove__);
		    DAT_ram_00a5acbe = '\x01';
		  }
		  Core_Files_RemoteFileRequest__RunRequest(param2,param2);
		  param1_00 = *(undefined4 *)(param1 + 8);
		  param2_00 = System_Uri__TryCreate(*(undefined4 *)(param2 + 0x10),0x10,2,0);
		  System_Linq_Enumerable__First_KeyValuePair_object__object__
		            (param1_00,param2_00,
		             Method_System_Collections_Generic_Dictionary_string__RemoteFileRequest__Remove__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0xA95D", Offset = "0xA95D", VA = "0xA95D")]
		private void CompleteFaultInternal(RemoteFileRequest request)
		{
		/* --- GHIDRA: CompleteFaultInternal ---
		void Core_Files_AbstractFileManager__CompleteFaultInternal
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  double dVar3;
		  int iVar4;
		  
		  iVar4 = *(int *)(param2 + 0x24);
		  if (iVar4 <= *(int *)(param2 + 0xc)) {
		    if (DAT_ram_00a5acc4 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		      DAT_ram_00a5acc4 = '\x01';
		      iVar4 = *(int *)(param2 + 0x24);
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    dVar3 = System_Math__Log10((double)(1.0 - (float)iVar4),3.0,0);
		    if (DAT_ram_00a5acbb == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Core_Files_AbstractFileManager__AwaitDownLoadRoutine_d__9_TypeInfo);
		      DAT_ram_00a5acbb = '\x01';
		    }
		    iVar4 = unnamed_function_1417
		                      (Core_Files_AbstractFileManager__AwaitDownLoadRoutine_d__9_TypeInfo);
		    *(undefined4 *)(iVar4 + 0x18) = param1;
		    *(undefined4 *)(iVar4 + 8) = 0;
		    *(float *)(iVar4 + 0x14) = (float)(1.0 - dVar3) / 1000.0;
		    *(int *)(iVar4 + 0x10) = param2;
		    Utils_CoroutineSource__GetMono(iVar4,0);
		    return;
		  }
		  Core_Files_AbstractFileManager__CompleteSuccessInternal(param1,param2,iVar4);
		  uVar1 = unnamed_function_2232(&StringLiteral_7831);
		  uVar1 = func_ii_4419(uVar1,param2,0);
		  uVar2 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  System_String__Concat(uVar2,uVar1,0);
		  uVar1 = unnamed_function_2232(&Method_Core_Files_AbstractFileManager_HandleError__);
		  func_ii_1050(uVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCC")]
		[Address(RVA = "0x22B9", Offset = "0x22B9", VA = "0x22B9")]
		private void HandleProtocolError(RemoteFileRequest request)
		{
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCD")]
		[Address(RVA = "0xA95E", Offset = "0xA95E", VA = "0xA95E", Slot = "7")]
		protected virtual void HandleError(RemoteFileRequest request)
		{
		}

		// Token: 0x06005CCE RID: 23758
		[Token(Token = "0x6005CCE")]
		protected abstract IEnumerator Complete(IFileContent content);

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<string, RemoteFileRequest> _awaitRequests;

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0xC")]
		private readonly int _timeout;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		private const int _maxNumAttempts = 20;
	}
}
