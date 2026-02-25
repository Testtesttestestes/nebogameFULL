using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.Data
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Serializable]
	public struct KeyValuePair<TKey, TValue>
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000078")]
		public TKey Key
		{
			[Token(Token = "0x6000336")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000079")]
		public TValue Value
		{
			[Token(Token = "0x6000337")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public TKey _key;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public TValue _value;
	}
}
