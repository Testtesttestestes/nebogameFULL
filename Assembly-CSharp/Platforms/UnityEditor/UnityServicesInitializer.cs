using System;
using Core.Application.Managers;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Platforms.UnityEditor
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public class UnityServicesInitializer : IUnityServicesInitializer
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x5B49", Offset = "0x5B49", VA = "0x5B49", Slot = "4")]
		public UniTask Run()
		{
			return default(UniTask);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x5B4A", Offset = "0x5B4A", VA = "0x5B4A")]
		private void InitService(UniTaskCompletionSource tcs)
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x5B4B", Offset = "0x5B4B", VA = "0x5B4B")]
		public UnityServicesInitializer()
		{
		}
	}
}
