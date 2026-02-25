using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View.Players.LongEffects
{
	// Token: 0x0200095C RID: 2396
	[Token(Token = "0x200095C")]
	public class LongEffectsView : MonoBehaviour
	{
		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060038CE RID: 14542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B31")]
		public Transform LongEffectContainer
		{
			[Token(Token = "0x60038CE")]
			[Address(RVA = "0x886C", Offset = "0x886C", VA = "0x886C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038CF")]
		[Address(RVA = "0x886D", Offset = "0x886D", VA = "0x886D")]
		public void ValidateControlsEnabled(int count)
		{
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D0")]
		[Address(RVA = "0x886E", Offset = "0x886E", VA = "0x886E")]
		private void OnDestroy()
		{
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x886F", Offset = "0x886F", VA = "0x886F")]
		private void Awake()
		{
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x8870", Offset = "0x8870", VA = "0x8870")]
		private void Start()
		{
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D3")]
		[Address(RVA = "0x8871", Offset = "0x8871", VA = "0x8871")]
		private void ValidateControls(int count)
		{
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D4")]
		[Address(RVA = "0x8872", Offset = "0x8872", VA = "0x8872")]
		private void HandleDownClickEvent()
		{
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D5")]
		[Address(RVA = "0x8873", Offset = "0x8873", VA = "0x8873")]
		private void HandleUpClickEvent()
		{
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x60038D6")]
		[Address(RVA = "0x8874", Offset = "0x8874", VA = "0x8874")]
		private bool GetScrollValue(bool scrollDown, out float position)
		{
			return default(bool);
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D7")]
		[Address(RVA = "0x8875", Offset = "0x8875", VA = "0x8875")]
		public LongEffectsView()
		{
		}

		// Token: 0x04001F5E RID: 8030
		[Token(Token = "0x4001F5E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform[] _controls;

		// Token: 0x04001F5F RID: 8031
		[Token(Token = "0x4001F5F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _upButton;

		// Token: 0x04001F60 RID: 8032
		[Token(Token = "0x4001F60")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _downButton;

		// Token: 0x04001F61 RID: 8033
		[Token(Token = "0x4001F61")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _longEffectConatiner;

		// Token: 0x04001F62 RID: 8034
		[Token(Token = "0x4001F62")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected ScrollRect _scrollView;

		// Token: 0x04001F63 RID: 8035
		[Token(Token = "0x4001F63")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(7f, 200f)]
		private int _maxCountForScroll;

		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		[FieldOffset(Offset = "0x28")]
		private float _scrollDuration;

		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		[FieldOffset(Offset = "0x2C")]
		private int _count;
	}
}
