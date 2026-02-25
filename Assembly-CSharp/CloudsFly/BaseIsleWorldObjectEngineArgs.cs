using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012F2 RID: 4850
	[Token(Token = "0x20012F2")]
	[Serializable]
	public abstract class BaseIsleWorldObjectEngineArgs : WorldObjectEngineArgs
	{
		// Token: 0x06007375 RID: 29557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007375")]
		[Address(RVA = "0xBD62", Offset = "0xBD62", VA = "0xBD62")]
		protected BaseIsleWorldObjectEngineArgs()
		{
		}

		// Token: 0x04003C6B RID: 15467
		[Token(Token = "0x4003C6B")]
		[FieldOffset(Offset = "0x44")]
		public Transform IsleCloudContainer;

		// Token: 0x04003C6C RID: 15468
		[Token(Token = "0x4003C6C")]
		[FieldOffset(Offset = "0x48")]
		public BaseIsleWorldObject _baseIslePrefab;
	}
}
