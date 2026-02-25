using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	public class SkillsInfoView : BaseInfoBox
	{
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042C")]
		public UserData User
		{
			[Token(Token = "0x60017FB")]
			[Address(RVA = "0x69B6", Offset = "0x69B6", VA = "0x69B6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017FC")]
			[Address(RVA = "0x69B7", Offset = "0x69B7", VA = "0x69B7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700042D")]
		public GameRawImage ExpIcon
		{
			[Token(Token = "0x60017FD")]
			[Address(RVA = "0x69B8", Offset = "0x69B8", VA = "0x69B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700042E")]
		public TextMeshProUGUI ExpLabelField
		{
			[Token(Token = "0x60017FE")]
			[Address(RVA = "0x69B9", Offset = "0x69B9", VA = "0x69B9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700042F")]
		public TextMeshProUGUI ExpValueField
		{
			[Token(Token = "0x60017FF")]
			[Address(RVA = "0x69BA", Offset = "0x69BA", VA = "0x69BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000430")]
		public GameObject ExpBlock
		{
			[Token(Token = "0x6001800")]
			[Address(RVA = "0x69BB", Offset = "0x69BB", VA = "0x69BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x69BC", Offset = "0x69BC", VA = "0x69BC")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x69BD", Offset = "0x69BD", VA = "0x69BD", Slot = "5")]
		public override void UpdateInfo()
		{
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001803")]
		[Address(RVA = "0x69BE", Offset = "0x69BE", VA = "0x69BE")]
		public SkillsInfoView()
		{
		}

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkillRow _skillPrefab;

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _expLabelField;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _expValueField;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameRawImage _expIcon;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _expBlock;

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x30")]
		public SkillCollection UserSkills;
	}
}
