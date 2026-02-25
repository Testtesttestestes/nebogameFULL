using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Extensions
{
	// Token: 0x02000EFF RID: 3839
	[Token(Token = "0x2000EFF")]
	public static class AssetBundleRequestExt
	{
		// Token: 0x06005D13 RID: 23827 RVA: 0x00010B90 File Offset: 0x0000ED90
		[Token(Token = "0x6005D13")]
		[Address(RVA = "0x3678", Offset = "0x3678", VA = "0x3678")]
		public static UniTask<UnityEngine.Object[]> LoadAllAssetsAwaitable(this AssetBundleRequest request, CancellationToken cancellationToken)
		{
			return default(UniTask<UnityEngine.Object[]>);
		}
	}
}
