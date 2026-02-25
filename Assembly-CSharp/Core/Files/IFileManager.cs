using System;
using Core.Log.Files;
using Il2CppDummyDll;

namespace Core.Files
{
	// Token: 0x02000EF7 RID: 3831
	[Token(Token = "0x2000EF7")]
	public interface IFileManager
	{
		// Token: 0x06005CE7 RID: 23783
		[Token(Token = "0x6005CE7")]
		void Load(string baseUri, string path, bool cacheOnDevice, Action<IFileContent> callback);

		// Token: 0x06005CE8 RID: 23784
		[Token(Token = "0x6005CE8")]
		void Load(string baseUri, string path, bool cacheOnDevice, Action<IFileContent> callback, FileDownloadLogger fileDownloadLogger);
	}
}
