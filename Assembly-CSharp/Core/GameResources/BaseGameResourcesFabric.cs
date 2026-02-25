using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Core.GameResources
{
	// Token: 0x02000ECA RID: 3786
	[Token(Token = "0x2000ECA")]
	public class BaseGameResourcesFabric<Y, T> where Y : AbstractGameResourceLoader<T>, new() where T : Delegate
	{
		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06005C35 RID: 23605 RVA: 0x000108F0 File Offset: 0x0000EAF0
		[Token(Token = "0x170012B6")]
		public int TotalResourceCount
		{
			[Token(Token = "0x6005C35")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C36")]
		public BaseGameResourcesFabric()
		{
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005C37")]
		public string GetResourcesInfoString()
		{
			return null;
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C38")]
		public void GetResource(string url, T successCallback, [Optional] GameResourcesManager.ResourceFailedDelegate failCallback, bool cacheOnDevice = true)
		{
		}

		// Token: 0x06005C39 RID: 23609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C39")]
		public void ReleaseResource(string url)
		{
		}

		// Token: 0x04003260 RID: 12896
		[Token(Token = "0x4003260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<string, Y> _resourceLoaders;
	}
}
