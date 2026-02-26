using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Files
{
	// Token: 0x02000EF8 RID: 3832
	[Token(Token = "0x2000EF8")]
	public class LocalFileRequest : IFileInfo, IFileContent
	{
		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012C4")]
		public string Path
		{
			[Token(Token = "0x6005CE9")]
			[Address(RVA = "0xA972", Offset = "0xA972", VA = "0xA972", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06005CEA RID: 23786 RVA: 0x00010A70 File Offset: 0x0000EC70
		[Token(Token = "0x170012C5")]
		public bool CacheOnDevice
		{
			[Token(Token = "0x6005CEA")]
			[Address(RVA = "0xA973", Offset = "0xA973", VA = "0xA973", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06005CEB RID: 23787 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012C6")]
		public IFileInfo FileInfo
		{
			[Token(Token = "0x6005CEB")]
			[Address(RVA = "0xA974", Offset = "0xA974", VA = "0xA974", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CEC")]
		[Address(RVA = "0xA975", Offset = "0xA975", VA = "0xA975")]
		public LocalFileRequest(string path, byte[] content)
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Files_LocalFileRequest___ctor(int param1,undefined4 *param2,undefined4 param3)
		
		{
		  *param2 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(param1 + 0xc) != 0) {
		    return (uint)(*(int *)(*(int *)(param1 + 0xc) + 0xc) != 0);
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x06005CED RID: 23789 RVA: 0x00010A88 File Offset: 0x0000EC88
		[Token(Token = "0x6005CED")]
		[Address(RVA = "0xA976", Offset = "0xA976", VA = "0xA976", Slot = "8")]
		public bool TryGetContent(out byte[] bytes)
		{
			return default(bool);
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		[Token(Token = "0x6005CEE")]
		[Address(RVA = "0xA977", Offset = "0xA977", VA = "0xA977", Slot = "6")]
		public bool TryGetResponseHeader(string key, out string value)
		{
		/* --- GHIDRA: TryGetResponseHeader ---
		undefined4 Core_Files_LocalFileRequest__TryGetResponseHeader(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Uri__TryCreate(*(undefined4 *)(param1 + 0x10),0x10,2,0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x040032B9 RID: 12985
		[Token(Token = "0x40032B9")]
		[FieldOffset(Offset = "0xC")]
		private readonly byte[] _content;
	}
}
