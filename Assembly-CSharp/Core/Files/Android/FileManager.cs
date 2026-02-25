using System;
using System.Collections;
using Il2CppDummyDll;

namespace Core.Files.Android
{
	// Token: 0x02000EFC RID: 3836
	[Token(Token = "0x2000EFC")]
	public class FileManager : AbstractFileManager
	{
		// Token: 0x06005D07 RID: 23815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D07")]
		[Address(RVA = "0xA98F", Offset = "0xA98F", VA = "0xA98F")]
		public FileManager(int timeout)
		{
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D08")]
		[Address(RVA = "0xA990", Offset = "0xA990", VA = "0xA990", Slot = "6")]
		public override void Load(string baseUri, string path, bool cacheOnDevice, Action<IFileContent> callback)
		{
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D09")]
		[Address(RVA = "0xA991", Offset = "0xA991", VA = "0xA991", Slot = "8")]
		protected override IEnumerator Complete(IFileContent content)
		{
			return null;
		}
	}
}
