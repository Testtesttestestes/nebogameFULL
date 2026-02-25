using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000953 RID: 2387
	[Token(Token = "0x2000953")]
	public class SkillsInfoVisibilityHandler : MonoBehaviour
	{
		// Token: 0x1400017F RID: 383
		// (add) Token: 0x0600388E RID: 14478 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600388F RID: 14479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017F")]
		public event Action<bool> SkillVisibleChangedEvent
		{
			[Token(Token = "0x600388E")]
			[Address(RVA = "0x8838", Offset = "0x8838", VA = "0x8838")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600388F")]
			[Address(RVA = "0x8839", Offset = "0x8839", VA = "0x8839")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B26")]
		public SkillsInfo[] SkillsInfo
		{
			[Token(Token = "0x6003890")]
			[Address(RVA = "0x883A", Offset = "0x883A", VA = "0x883A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003891")]
		[Address(RVA = "0x883B", Offset = "0x883B", VA = "0x883B")]
		private void Awake()
		{
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003892")]
		[Address(RVA = "0x883C", Offset = "0x883C", VA = "0x883C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003893")]
		[Address(RVA = "0x883D", Offset = "0x883D", VA = "0x883D")]
		public void OpenAll()
		{
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003894")]
		[Address(RVA = "0x883E", Offset = "0x883E", VA = "0x883E")]
		public void CloseAll()
		{
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003895")]
		[Address(RVA = "0x883F", Offset = "0x883F", VA = "0x883F")]
		public SkillsInfoVisibilityHandler()
		{
		}

		// Token: 0x04001F48 RID: 8008
		[Token(Token = "0x4001F48")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SkillsInfo[] _skillsInfo;
	}
}
