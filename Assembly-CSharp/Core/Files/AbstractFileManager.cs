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
			return default(bool);
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC6")]
		[Address(RVA = "0xA958", Offset = "0xA958", VA = "0xA958")]
		private void Download(RemoteFileRequest fileRequest)
		{
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC7")]
		[Address(RVA = "0xA959", Offset = "0xA959", VA = "0xA959")]
		private void ScheduleDownload(RemoteFileRequest request, float delaySeconds)
		{
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CC8")]
		[Address(RVA = "0xA95A", Offset = "0xA95A", VA = "0xA95A")]
		private IEnumerator AwaitDownLoadRoutine(RemoteFileRequest request, float delaySeconds)
		{
			return null;
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0xA95B", Offset = "0xA95B", VA = "0xA95B")]
		private IEnumerator DownloadRoutine(RemoteFileRequest request)
		{
			return null;
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0xA95C", Offset = "0xA95C", VA = "0xA95C")]
		private IEnumerator CompleteSuccessInternal(RemoteFileRequest request)
		{
			return null;
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0xA95D", Offset = "0xA95D", VA = "0xA95D")]
		private void CompleteFaultInternal(RemoteFileRequest request)
		{
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
