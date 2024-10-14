fn main() {
    print!("GOOMB");

    std::io::Write::flush(&mut std::io::stdout()).unwrap();

    loop {
        print!("A");
        std::io::Write::flush(&mut std::io::stdout()).unwrap();
    }
}
